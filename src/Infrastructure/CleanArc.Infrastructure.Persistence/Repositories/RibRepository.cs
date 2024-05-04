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
            var ribs = new TR_RIB_DTO();
            var fullRib = ribs.RIB_RIB1 + ribs.RIB_RIB2 + ribs.RIB_RIB3;
            ribs.RIB_RIB = fullRib;

            if (!await verifExistingRib(ribs.RIB_RIB))
            {
                ribs.ACTIF_RIB = true;
                _dbContext.TR_RIBs.Add(rib);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception e)
        { return false;
        }
    }
    
    public async Task<PagedList<TR_RIB>> GetAllRibsByIndividuAsync(int refIndRib, PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.Where(r => r.REF_IND_RIB == refIndRib).AsQueryable();
        var result = await PagedList<TR_RIB>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        return result;
    }


    public async Task<TR_RIB> GetRibById(string id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.RIB_RIB == id);
    }

    private Task<bool> verifExistingRib(string rib)
    {
        return Task.FromResult(_dbContext.TR_RIBs.Any(p => p.RIB_RIB == rib));
    }

    public async Task<TR_RIB_DTO> EditRibIndividu(TR_RIB_DTO rib)
    {
        var currentRib = _dbContext.TR_RIBs.FirstOrDefault(p => p.RIB_RIB == rib.OLD_RIB_RIB);
        var newRib = rib.RIB_RIB1 + rib.RIB_RIB2 + rib.RIB_RIB3;
        if (currentRib != null)
        {
            if (currentRib.RIB_RIB != newRib)
            {
                var ribExists = await verifExistingRib(newRib);
                if (!ribExists)
                {
                    _dbContext.TR_RIBs.Remove(currentRib);
                    var trRib= new TR_RIB
                    {
                        RIB_RIB =newRib,
                        REF_IND_RIB = currentRib.REF_IND_RIB,
                        ACTIF_RIB = rib.ACTIF_RIB
                    };
                    _dbContext.TR_RIBs.Add(trRib);
                }
                else
                {
                    return new TR_RIB_DTO { Success= false, Message = $"Le RIB '{newRib}' existe." };
                }
            }
            else
            {
                currentRib.ACTIF_RIB = rib.ACTIF_RIB;
                _dbContext.Entry(currentRib).State = EntityState.Modified;
            }
            await _dbContext.SaveChangesAsync();
            return new TR_RIB_DTO { Success = true, Message = $"Le RIB a été modifié avec succès." };
        }
        else
        {
            
            return new TR_RIB_DTO { Success = false, Message = $"Le RIB '{rib.OLD_RIB_RIB}' n'existe pas." };
        }
    }

}