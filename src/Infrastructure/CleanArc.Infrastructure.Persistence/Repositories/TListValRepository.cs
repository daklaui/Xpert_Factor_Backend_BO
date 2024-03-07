using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using CleanArc.Application.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class TListValRepository : BaseAsyncRepository<TRListVals>, ITListValRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public TListValRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<PagedList<TRListVals>> GetAllTListValsAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            return await PagedList<TRListVals>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        }

        public async Task<TRListVals> AddTListValAsync(TRListVals tListVal)
        {
            if (tListVal == null)
            {
                throw new ArgumentNullException(nameof(tListVal), "Cannot add a null entity");
            }

            await base.AddAsync(tListVal);
            return tListVal;
        }


        public async Task<TRListVals> GetTListValById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<TRListVals> UpdateTListValAsync(int id, TRListVals updatedTListVal)
        {
            var tListVal = await _dbContext.Set<TRListVals>().FirstOrDefaultAsync(e => e.Id == id);

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