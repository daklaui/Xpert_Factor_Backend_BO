using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using System.Web;
using CleanArc.Application.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class ListValRepository:BaseAsyncRepository<TR_LIST_VAL>,IListValRepository
{
    private readonly ApplicationDbContext _dbContext;
    public ListValRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
        
    public async Task<PagedList<TR_LIST_VAL>> GetAllTListValsAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        return await PagedList<TR_LIST_VAL>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    }   
    
    
    public async Task<List<TR_LIST_VAL>> GetFormJuridique()
    {
        var query = base.TableNoTracking.AsQueryable().Where(p =>p.TYP_LIST_VAL == "Forme juridique");
        return query.ToList();
    }

    public async Task<TR_LIST_VAL> AddTListValAsync(TR_LIST_VAL listVal)
    {
        if (listVal == null)
        {
            throw new ArgumentNullException(nameof(listVal), "Cannot add a null entity");
        }

        await base.AddAsync(listVal);
        return listVal;
    }


    public async Task<TR_LIST_VAL> GetTListValById(int id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_LIST_VAL == id);
    }

    public async Task<TR_LIST_VAL> UpdateTListValAsync(int id, TR_LIST_VAL updatedTListVal)
    {
        var listVal = await base.Table.FirstOrDefaultAsync(e => e.ID_LIST_VAL == id);

        if (listVal == null)
        {
            throw new InvalidOperationException($"ListVals with id {id} not found");
        }

        listVal.ABR_LIST_VAL = updatedTListVal.ABR_LIST_VAL;
        listVal.TYP_LIST_VAL = updatedTListVal.TYP_LIST_VAL;
        listVal.ORD_LIST_VAL = updatedTListVal.ORD_LIST_VAL;
        listVal.LIB_LIST_VAL = updatedTListVal.LIB_LIST_VAL;
        listVal.COM_LIST_VAL = updatedTListVal.COM_LIST_VAL;

        await base.UpdateAsync(listVal);
        return listVal;
    }

    public async Task<List<TR_LIST_VAL>> GetAllRecouvrementAsync()
    {
        var listVal =  base.Entities
            .Where(p => p.TYP_LIST_VAL == "COMM_RECOUV")
            .Select(p => new TR_LIST_VAL { LIB_LIST_VAL = p.LIB_LIST_VAL })
            .ToList();

        return listVal;
    }
}