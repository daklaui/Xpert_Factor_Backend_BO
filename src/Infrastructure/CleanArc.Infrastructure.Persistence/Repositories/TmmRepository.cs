using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace CleanArc.Infrastructure.Persistence.Repositories
{

    internal class TmmRepository : BaseAsyncRepository<TTMM>, ITmmRepository
    {
        public TmmRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddTmmAsync(TTMM tmm)
        {
            await base.AddAsync(tmm);
        }

        public async Task<PagedList<TTMM>> GetAllTmmAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<TTMM>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<TTMM> GetTmmByIdAsync(int id)
        {
            return await base.TableNoTracking.FirstAsync(p => p.Id == id);

        }

        public async Task UpdateTmmAsync(TTMM tmm)
        {
            await base.UpdateAsync(tmm);
        }
    }
}
