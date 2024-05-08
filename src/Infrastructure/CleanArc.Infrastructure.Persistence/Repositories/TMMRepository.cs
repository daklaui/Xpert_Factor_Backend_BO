using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class TmmRepository :BaseAsyncRepository<TR_TMM>, ITMMRepository
{
    public TmmRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async  Task <TR_TMM> AddTrTmmAsync(TR_TMM trTmm)
    {
        trTmm.ID_TMM = 0;
        if (trTmm == null)
        {
            throw new ArgumentNullException(nameof(trTmm), "Cannot add a null entity");
        }

        await base.AddAsync(trTmm);
        return trTmm;
    }

    public async Task<PagedList<TR_TMM>> GetAllTrTmmAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<TR_TMM>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task<TR_TMM> GetTrTmmById(int id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_TMM == id);

    }

    public  async Task<bool> UpdateTrTmmAsync(int id,TR_TMM trTmmUpdate )
    {
        var existingTrmm = await base.Table.FirstOrDefaultAsync(p => p.ID_TMM == id);

        if (existingTrmm == null)
        {
            throw new InvalidOperationException($"TMM with id {id} not found");
        }

        existingTrmm.ID_TMM = trTmmUpdate.ID_TMM;
        existingTrmm.DATE_DEBUT_TMM = trTmmUpdate.DATE_DEBUT_TMM;
        existingTrmm.DATE_DEBUT_TMM = trTmmUpdate.DATE_DEBUT_TMM;
        existingTrmm.DATE_FIN_TMM = trTmmUpdate.DATE_FIN_TMM;
        existingTrmm.TAUX_TMM = trTmmUpdate.TAUX_TMM;
        await base.UpdateAsync(existingTrmm);
        return true;  
    }
}