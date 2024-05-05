using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class LimiteRepository : BaseAsyncRepository<T_DEM_LIMITE> ,ILimiteRepository
{
    private readonly ApplicationDbContext _dbContext;
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
    public async Task<DemLimListingDTO> checkExistingLimiteNoActif(int refCtr, int refInd)
    {
        throw new NotImplementedException();
    }

    public async Task<List<T_DEM_LIMITE_DTO>> getListOfDemLimitNoActif()
    {
        throw new NotImplementedException();
    }
    public Task<List<T_DEM_LIMITE_DTO>> getAllLDemLimites()
    {
        throw new NotImplementedException();
    }
    public Task<bool> validateLimite(int id)
    {
        throw new NotImplementedException();
    }
}

