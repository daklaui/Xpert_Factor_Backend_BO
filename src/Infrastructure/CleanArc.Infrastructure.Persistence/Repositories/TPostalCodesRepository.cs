using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using CleanArc.Application.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class TPostalCodesRepository : BaseAsyncRepository<TR_CP>, ITPostalCodesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TPostalCodesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PagedList<TR_CP>> GetAllTPostalCodesAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            return await PagedList<TR_CP>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        }

        public async Task<TR_CP> AddTPostalCodesAsync(TR_CP trCp)
        {
            if (trCp == null)
            {
                throw new ArgumentNullException(nameof(trCp), "Cannot add a null entity");
            }

            await base.AddAsync(trCp);
            return trCp;
        }

        public async Task<TR_CP> GetTPostalCodesById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<TR_CP> UpdateTPostalCodesAsync(int id, TR_CP updatedTPostalCodes)
        {
            var tPostalCodes = await _dbContext.Set<TR_CP>().FirstOrDefaultAsync(e => e.Id == id);

            if (tPostalCodes == null)
            {
                throw new InvalidOperationException($"TPostalCodes with id {id} not found");
            }

            tPostalCodes.CodeGouvernorat = updatedTPostalCodes.CodeGouvernorat;
            tPostalCodes.CodeRegion = updatedTPostalCodes.CodeRegion;
            tPostalCodes.Cp = updatedTPostalCodes.Cp;
            tPostalCodes.Gouvernorat = updatedTPostalCodes.Gouvernorat;
            tPostalCodes.Region = updatedTPostalCodes.Region;
            tPostalCodes.Ville = updatedTPostalCodes.Ville;
            tPostalCodes.ModifiedDate = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            return tPostalCodes;
        }
    }
}
