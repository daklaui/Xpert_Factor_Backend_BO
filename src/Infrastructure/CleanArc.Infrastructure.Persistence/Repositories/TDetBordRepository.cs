using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class TDetBordRepository :BaseAsyncRepository<T_DET_BORD> ,IT_DET_BORD_Repository
{
    private readonly ApplicationDbContext _dbContext;

    public TDetBordRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task addT_DET_BORD_Async(T_DET_BORD detBord)
    {
        await base.AddAsync(detBord);
    }
    
    public async Task<PagedList<T_DET_BORD>> GetAllT_DET_BORD_Async(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();

        var result = await PagedList<T_DET_BORD>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

        return result;
    }

   public async Task<T_DET_BORD> GetT_DET_BORD_Byid(string id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_DET_BORD == id);
    }
   
   public async  Task DeleteT_DET_BORD(T_DET_BORD detBord)
   {
       _dbContext.Set<T_DET_BORD>().Remove(detBord);
   }
}