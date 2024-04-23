using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class FinancementRepository :BaseAsyncRepository<T_FINANCEMENT>,IFinancementRepository
{
    private readonly ApplicationDbContext _dbContext;

    public FinancementRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public  async Task<PagedList<T_FINANCEMENT>> GetAllFinancementAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<T_FINANCEMENT>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

        return result;
    }
    
    public async Task<T_FINANCEMENT> AddFinanceAsync(T_FINANCEMENT finance)
    {
        finance.ID_FIN = 0;
        if (finance == null)
        {
            throw new ArgumentNullException(nameof(finance), "Cannot add a null entity");
        }

        await base.AddAsync(finance);
   
        return finance;    
    }
    public async Task<T_FINANCEMENT> GetFinanceById(int id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_FIN == id);

    }
    public async Task<T_FINANCEMENT> ValidateFinanceAsync(int id, T_FINANCEMENT finance)   
    {
        var tFinance = await _dbContext.Set<T_FINANCEMENT>().FirstOrDefaultAsync(e => e.ID_FIN == id);
        
        if (tFinance == null)
        {
            
            throw new InvalidOperationException($"Financement with id {id} not found");
        }

        tFinance.ETAT_FIN = "valider";
        await _dbContext.SaveChangesAsync();
        return tFinance;
    }

    public async Task<T_FINANCEMENT> RejectFinanceAsync(int id, T_FINANCEMENT finance)
    {
        var tFinance = await _dbContext.Set<T_FINANCEMENT>().FirstOrDefaultAsync(e => e.ID_FIN == id);
        
        if (tFinance == null)
        {
            
            throw new InvalidOperationException($"Financement with id {id} not found");
        }

        tFinance.ETAT_FIN = "rejeter";
        await _dbContext.SaveChangesAsync();
        return tFinance;
    }
}

