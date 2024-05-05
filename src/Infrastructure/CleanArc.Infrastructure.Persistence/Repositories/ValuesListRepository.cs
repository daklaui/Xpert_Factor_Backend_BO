using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class ValuesListRepository : BaseAsyncRepository<TR_LIST_VAL>, IValuesListRepository
{
    private readonly ApplicationDbContext _dbContext;
    public ValuesListRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async  Task <TR_LIST_VAL> AddListValAsync(TR_LIST_VAL listVal)
    {
        listVal.ID_LIST_VAL = 0;
        if (listVal == null)
        {
            throw new ArgumentNullException(nameof(listVal), "Cannot add a null entity");
        }

        await base.AddAsync(listVal);
        return listVal;
    }
    public  async Task UpdateListValAsync(TR_LIST_VAL listVal)
    {
        await base.UpdateAsync1(listVal);
    }
    
    public async Task<PagedList<TR_LIST_VAL>> GetFormJuridiqueList(PaginationParams paginationParams)
    {
        var query = _dbContext.TR_LIST_VALs
            .Where(q => q.TYP_LIST_VAL == "Forme juridique")
            .AsQueryable();

        return await PagedList<TR_LIST_VAL>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    }
    public async Task<PagedList<TR_LIST_VAL>> GetContactsList(PaginationParams paginationParams)
    {
        var query = _dbContext.TR_LIST_VALs
            .Where(q => q.TYP_LIST_VAL == "Contact")
            .AsQueryable();
        return await PagedList<TR_LIST_VAL>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    }

    public async Task<PagedList<TR_NLDP>> GetLangList(PaginationParams paginationParams)
    {
        var query = _dbContext.TR_NLDPs.AsQueryable();
        return await PagedList<TR_NLDP>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    }
    
    

}