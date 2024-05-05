/*using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class ActProfRepository : BaseAsyncRepository<TR_ACTPROF_BCT>, IActProfRepository

{
    private readonly ApplicationDbContext _dbContext;

    public ActProfRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public async  Task <TR_ACTPROF_BCT> AddActprofAsync(TR_ACTPROF_BCT actprofBct)
    {
        actprofBct.Code_SousClasse="";
        if (actprofBct == null)
        { 
            throw new ArgumentNullException(nameof(actprofBct), "Cannot add a null entity");
        }

        await base.AddAsync(actprofBct);
        return actprofBct;
    }
    public  async Task UpdateActprofAsync(TR_ACTPROF_BCT actprofBct)
    {
        await base.UpdateAsync1(actprofBct);
    }
    
    public async Task<PagedList<TR_ACTPROF_BCT>> GetJobsList(string paginationParams)
    {
        var query = _dbContext.TR_ACTPROF_BCTs
            .OrderBy(p => p.SousClasse)
            .AsQueryable();
        return await PagedList<TR_ACTPROF_BCT>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

    }

   
}*/