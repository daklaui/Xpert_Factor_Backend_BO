using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class BordereauxRepository : BaseAsyncRepository<T_BORDEREAU>, IBordereauxRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BordereauxRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task addBordereauxAsync(T_BORDEREAU bordereau)
        {
            await base.AddAsync(bordereau);
        }

        public async Task<PagedList<T_BORDEREAU>> GetAllBordereauxAsync(PaginationParams paginationParams)
        {
            // Assuming BaseAsyncRepository provides basic query functionality
            var query = base.TableNoTracking.AsQueryable();

            // Apply filtering, sorting, etc. based on paginationParams (if needed)

            var result = await PagedList<T_BORDEREAU>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<T_BORDEREAU> GetBordereauxById(string id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.NUM_BORD == id); // Assuming Id property
        }

        public async Task DeleteBordereaux(T_BORDEREAU bordereau)
        {
            _dbContext.Set<T_BORDEREAU>().Remove(bordereau);
        }
    }
}