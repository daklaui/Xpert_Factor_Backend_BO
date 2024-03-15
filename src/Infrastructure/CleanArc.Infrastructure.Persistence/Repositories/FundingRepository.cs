using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class FinancementRepository :BaseAsyncRepository<T_FINANCEMENT>,IFinancementRepository
{
    public FinancementRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public  async Task<T_FINANCEMENT> GetFinancementById(int REF_CTR)
    {
        var financement = await base.TableNoTracking.FirstOrDefaultAsync(p => p.REF_CTR_FIN == REF_CTR);

        if (financement == null)
        {
            throw new Exception("Financement not found"); 
        }

        return financement;    }

    public async Task AddFinancementAsync(T_FINANCEMENT financement)
    {
        await base.AddAsync(financement);

    }
}