using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;


namespace CleanArc.Infrastructure.Persistence.Repositories

{
    internal class DebitRepository : BaseAsyncRepository<T_MVT_DEBIT>, IDebitRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public DebitRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task addDebitAsync(T_MVT_DEBIT debit)
        {
            await base.AddAsync(debit);
        }

    }
}