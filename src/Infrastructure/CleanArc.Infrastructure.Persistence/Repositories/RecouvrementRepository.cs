using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class RecouvrementRepository: BaseAsyncRepository<TR_LIST_VAL>, IRecouvrementRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RecouvrementRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PagedList<TR_LIST_VAL>> GetAllRecAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable().Where(p => p.TYP_LIST_VAL == "COMM_RECOV"); 
        var result = await PagedList<TR_LIST_VAL>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    
        return result;
    }

}