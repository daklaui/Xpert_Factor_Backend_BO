using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class RibRepository : BaseAsyncRepository<TR_RIB>, IRibRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RibRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> AddRibAsync(TR_RIB rib)
    {
        try
        {
            if (!await verifExistingRib(rib.RIB_RIB))
            {
                await base.AddAsync(rib);
                return true;
            }
            else
            {

                throw new Exception($"Le RIB '{rib.RIB_RIB}' existe déjà.");
            }
        }
        catch (Exception ex)
        {

            throw new Exception("Erreur lors de l'ajout du RIB.", ex);
        }
    }

    private Task<bool> verifExistingRib(string rib)
    {

        return Task.FromResult(base.Table.Any(p => p.RIB_RIB == rib));
    }


    public async Task<PagedList<TR_RIB>> GetAllRibsAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<TR_RIB>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

        return result;
    }


    public async Task<TR_RIB> GetRibById(int id)
    {
        return await base.TableNoTracking.FirstAsync(p => p.ID_RIB == id);
    }


    public async Task<TR_RIB> EditRibIndividu(int id, TR_RIB rib)
    {
  
        var currentRib = await _dbContext.TR_RIBs.FirstOrDefaultAsync(p => p.ID_RIB == id);

        if (currentRib == null)
        {
            throw new InvalidOperationException("Le RIB spécifié n'existe pas.");
        }

        if (await _dbContext.TR_RIBs.AnyAsync(p => p.RIB_RIB == rib.RIB_RIB && p.ID_RIB != id))
        {
            throw new InvalidOperationException($"Le RIB '{rib.RIB_RIB}' existe déjà.");
        }

  
        currentRib.RIB_RIB = rib.RIB_RIB;
        currentRib.ACTIF_RIB = rib.ACTIF_RIB;

        
        await _dbContext.SaveChangesAsync();

        return currentRib;
    }
    public async Task<TR_RIB> GetRibByRibValueAsync(string ribValue)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.RIB_RIB == ribValue);
    }
}





    
    
    

