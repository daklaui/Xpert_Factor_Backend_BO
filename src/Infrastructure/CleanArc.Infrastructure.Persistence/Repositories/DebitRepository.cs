using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class DebitRepository:BaseAsyncRepository<T_MVT_DEBIT>,IDebitRepository
{
    private readonly ApplicationDbContext _dbContext;
    public DebitRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddDebitAsync(T_MVT_DEBIT mvtDebit)
    {
       await    base.AddAsync(mvtDebit);
    }
  
}