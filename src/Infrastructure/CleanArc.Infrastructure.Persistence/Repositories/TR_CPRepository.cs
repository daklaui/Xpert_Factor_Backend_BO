using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class TR_CPRepository : BaseAsyncRepository<TR_CP>, ITR_CPRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TR_CPRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddTR_CPAsync(TR_CP tr_cp)
        {
            await base.AddAsync(tr_cp);
        }

        public async Task<PagedList<TR_CP>> GetAllTR_CPsAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<TR_CP>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<TR_CP> GetTR_CPById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_CP == id);
        }


        public async Task<bool> UpdateTR_CPAsync(int id, TR_CP updatedTR_CP)
        {
            var existingTR_CP = await base.Table.FirstOrDefaultAsync(e => e.ID_CP == id);

            if (existingTR_CP == null)
            {
                throw new InvalidOperationException($"TR_CP with id {id} not found");
            }

            existingTR_CP.CP = updatedTR_CP.CP;
            existingTR_CP.Ville = updatedTR_CP.Ville;
            existingTR_CP.Code_Gouvernorat = updatedTR_CP.Code_Gouvernorat;
            existingTR_CP.Gouvernorat = updatedTR_CP.Gouvernorat;
            existingTR_CP.Code_Region = updatedTR_CP.Code_Region;
            existingTR_CP.Region = updatedTR_CP.Region;

            await base.UpdateAsync(existingTR_CP);

            return true;
        }
    }
}
