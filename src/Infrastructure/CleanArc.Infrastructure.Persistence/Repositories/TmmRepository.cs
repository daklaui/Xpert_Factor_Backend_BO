using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace CleanArc.Infrastructure.Persistence.Repositories
{

    internal class TmmRepository : BaseAsyncRepository<TMM>, ITmmRepository
    {
        public TmmRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddTmmAsync(TMM tmm)
        {
            await base.AddAsync(tmm);
        }

        public async Task<PagedList<TMM>> GetAllTmmAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<TMM>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<TMM> GetTmmByIdAsync(int id)
        {
            return await base.TableNoTracking.FirstAsync(p => p.Id == id);

        }

        public async Task UpdateTmmAsync(TMM tmm)
        {
           // await base.UpdateAsync(bankAgency);
        }
    }
}
