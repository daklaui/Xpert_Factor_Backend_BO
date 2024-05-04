
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;


namespace CleanArc.Infrastructure.Persistence.Repositories

{
    public class CreditRepository : BaseAsyncRepository<T_MVT_CREDIT>, ICreditRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CreditRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddCreditAsync(T_MVT_CREDIT credit)
        {
            await base.AddAsync(credit);
        }

    }
}
