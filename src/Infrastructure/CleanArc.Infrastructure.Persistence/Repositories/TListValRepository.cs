using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class TListValRepository : BaseAsyncRepository<ListVals>, ITListValRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public TListValRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<PagedList<ListVals>> GetAllTListValsAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            return await PagedList<ListVals>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        }

        public async Task<ListVals> AddTListValAsync(ListVals tListVal)
        {
            if (tListVal == null)
            {
                throw new ArgumentNullException(nameof(tListVal), "Cannot add a null entity");
            }

            await base.AddAsync(tListVal);
            return tListVal;
        }


        public async Task<ListVals> GetTListValById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<ListVals> UpdateTListValAsync(int id, ListVals updatedTListVal)
        {
            var tListVal = await _dbContext.Set<ListVals>().FirstOrDefaultAsync(e => e.Id == id);

            if (tListVal == null)
            {
                throw new InvalidOperationException($"ListVals with id {id} not found");
            }

            tListVal.AbrListVal = updatedTListVal.AbrListVal;
            tListVal.TypListVal = updatedTListVal.TypListVal;
            tListVal.OrdListVal = updatedTListVal.OrdListVal;
            tListVal.LibListVal = updatedTListVal.LibListVal;
            tListVal.ComListVal = updatedTListVal.ComListVal;
            tListVal.ModifiedDate = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            return tListVal;
        }







    }
}