using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class IntFinanceRepository : BaseAsyncRepository<T_INT_FINANCEMENT>, IIntFinanceRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public IntFinanceRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddIntFinanceAsync(T_INT_FINANCEMENT intFinance)
        {
            await base.AddAsync(intFinance);
        }

        public Task<PagedList<T_INT_FINANCEMENT>> GetAllIntFinanceAsync(PaginationParams paginationParams)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T_INT_FINANCEMENT>> GetIntFinanceById(int id)
        {
            return await base.TableNoTracking.Where(p => p.REF_CTR_INT_FIN == id).ToListAsync();
        }

        public async Task<T_INT_FINANCEMENT> GetIntFinanceByRefCtrAndType(int refCtr, string type)
        {
            return await base.TableNoTracking.FirstAsync(p => p.REF_CTR_INT_FIN == refCtr && p.TYP_INSTR_INT_FIN == type);
        }

        public async Task<bool> UpdateIntFinanceAsync(int intFinanceId, T_INT_FINANCEMENT updatedIntFinance)
        {
            var existingIntFinance = await base.Table.FirstOrDefaultAsync(p => p.REF_CTR_INT_FIN == intFinanceId);

            if (existingIntFinance == null)
            {
                throw new InvalidOperationException($"Interest finance with id {intFinanceId} not found");
            }

            await base.UpdateAsync(existingIntFinance);

            return true;
        }
    }
}