using System;
using System.Linq;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class FactoringCommissionRepository : BaseAsyncRepository<T_COMM_FACTORING>, IFactoringCommissionRepository
    {
        public FactoringCommissionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddFactoringCommissionAsync(T_COMM_FACTORING factoringCommission)
        {
            await base.AddAsync(factoringCommission);
        }

        public async Task<PagedList<T_COMM_FACTORING>> GetAllFactoringCommissionsAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<T_COMM_FACTORING>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
            return result;
        }

        public async Task<T_COMM_FACTORING> GetFactoringCommissionById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.REF_CTR_COMM_FACTORING == id);
        }

        public async Task<bool> UpdateFactoringCommissionAsync(int id, T_COMM_FACTORING updatedFactoringCommission)
        {
            var existingFactoringCommission = await base.Table.FirstOrDefaultAsync(e => e.REF_CTR_COMM_FACTORING == id);

            if (existingFactoringCommission == null)
            {
                throw new InvalidOperationException($"Factoring commission with id {id} not found");
            }

            existingFactoringCommission.TYP_COMM_FACTORING = updatedFactoringCommission.TYP_COMM_FACTORING;
            existingFactoringCommission.TX_COMM_FACTORING = updatedFactoringCommission.TX_COMM_FACTORING;
            existingFactoringCommission.MONT_MIN_DOC_COMM_FACTORING = updatedFactoringCommission.MONT_MIN_DOC_COMM_FACTORING;
            existingFactoringCommission.MONT_MIN_CTR_COMM_FACTORING = updatedFactoringCommission.MONT_MIN_CTR_COMM_FACTORING;

            await base.UpdateAsync(existingFactoringCommission);

            return true;
        }
    }
}
