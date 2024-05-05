using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class CpRepository : BaseAsyncRepository<TR_CP>, ICpRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CpRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TR_CP> AddCpAsync(TR_CP cp)
    {
        cp.ID_CP = 0;
        if (cp == null)
        {
            throw new ArgumentNullException(nameof(cp), "Cannot add a null entity");
        }

        await base.AddAsync(cp);
        return cp;
    }

    public  async Task UpdateCpAsync(TR_CP cp)
    {
        await base.UpdateAsync1(cp);
    }
    
    public async Task<PagedList<TR_CP>> GetPostsList(PaginationParams paginationParams)
    {
        var query = _dbContext.TR_CPs.AsQueryable();
        return await PagedList<TR_CP>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    }
}