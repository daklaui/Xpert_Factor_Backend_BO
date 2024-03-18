using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class LimiteRepository : BaseAsyncRepository<T_DEM_LIMITE> ,ILimiteRepository
{
    public LimiteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        
    }

    public async Task<T_DEM_LIMITE> AddTDemLimitesync(T_DEM_LIMITE demLimite)
    {
        if (demLimite == null)
        {
            throw new ArgumentNullException(nameof(demLimite), message: "Can not add a null entity");
        }

        await base.AddAsync(demLimite);
        return demLimite;
    }
}