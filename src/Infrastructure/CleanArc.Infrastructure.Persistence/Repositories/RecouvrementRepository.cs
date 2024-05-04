using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class RecouvrementRepository: BaseAsyncRepository<TR_LIST_VAL>, IRecouvrementRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RecouvrementRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddRecouvrementAsync(TR_LIST_VAL Recouvrement)
    {
        await base.AddAsync(Recouvrement);
    }
    public async Task<bool> UpdateDocumentDetBordAsync(int id , TR_LIST_VAL updatedRecouvrement)
    {
        var existingRecouvrement = await GetRecouvrementById(id);
        
        if (existingRecouvrement == null)
        {
            throw new InvalidOperationException($"Recouvrement with primary key ({id}) not found.");
        }
        existingRecouvrement.ABR_LIST_VAL = updatedRecouvrement.ABR_LIST_VAL;
        existingRecouvrement.TYP_LIST_VAL = updatedRecouvrement.TYP_LIST_VAL;
        existingRecouvrement.ORD_LIST_VAL = updatedRecouvrement.ORD_LIST_VAL;
        existingRecouvrement.LIB_LIST_VAL = updatedRecouvrement.LIB_LIST_VAL;
        existingRecouvrement.COM_LIST_VAL = updatedRecouvrement.COM_LIST_VAL;
        existingRecouvrement.NB_JOUR_LIST_VAL = updatedRecouvrement.NB_JOUR_LIST_VAL;
        existingRecouvrement.TYPE_RECOUVREMENT = updatedRecouvrement.TYPE_RECOUVREMENT;
        _dbContext.Entry(existingRecouvrement).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
        return true;
    }
    public async Task<TR_LIST_VAL> GetRecouvrementById(int id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.ID_LIST_VAL == id);
    }
    public async Task<PagedList<TR_LIST_VAL>> GetAllRecAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable().Where(p => p.TYP_LIST_VAL == "COMM_RECOUV"); 
        var result = await PagedList<TR_LIST_VAL>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    
        return result;
    }

}