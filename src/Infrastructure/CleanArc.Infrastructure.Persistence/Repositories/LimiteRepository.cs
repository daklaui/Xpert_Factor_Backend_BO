using CleanArc.Application.Common;
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
        _dbContext = dbContext;
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

    public async Task<T_DEM_LIMITE_DTO> checkExistingLimiteNoActif(int refCtr, int refInd)
    {
        var tab = from dem in base.Table
            join iach in _dbContext.T_INDIVIDUs on dem.REF_ACH_LIM equals iach.REF_IND
            join cach in _dbContext.TJ_CIRs on dem.REF_CTR_DEM_LIM equals cach.REF_CTR_CIR
            where (cach.ID_ROLE_CIR == "ACH" && cach.REF_IND_CIR == refCtr && cach.REF_IND_CIR == dem.REF_ACH_LIM
                   && dem.ACTIF_DEM_LIMI == false
                   && (dem.DECISION_LIM != "RF" && dem.DECISION_LIM != "V" && dem.DECISION_LIM != "C")
                   && dem.REF_CTR_DEM_LIM == refInd)
            select new T_DEM_LIMITE_DTO
            {
                REF_CTR_DEM_LIM = dem.REF_CTR_DEM_LIM,
                REF_ACH_LIM = dem.REF_ACH_LIM,
                ACTIF_DEM_LIMI = dem.ACTIF_DEM_LIMI,
                DAT_DEM_LIM = dem.DAT_DEM_LIM,
                REF_DEM_LIM = dem.REF_DEM_LIM,
                DECISION_LIM = dem.DECISION_LIM,
                DELAIS_DEM_LIM = dem.DELAIS_DEM_LIM,
                DEVISE = dem.DEVISE,
                MODE_PAY_DEM_LIM = dem.MODE_PAY_DEM_LIM,
                //MONT_DEM_LIM = dem.MONT_DEM_LIM,
                SORT_DEM_LIM = dem.SORT_DEM_LIM,
                TYP_DEM_LIM = dem.TYP_DEM_LIM,
                DELAIS_ACC = dem.DELAIS_ACC,
               // MONT_ACC = dem.MONT_ACC,
                MODE_PAY_ACC = dem.MODE_PAY_ACC,
            };

        var result = await tab.FirstOrDefaultAsync();
        return result;
    }
    
    public async Task<PagedList<T_DEM_LIMITE_DTO>> getListOfDemLimitNoActif(PaginationParams paginationParam)
                    { 
                        var demLim = (from dem in base.Table
                            join iach in _dbContext.T_INDIVIDUs on dem.REF_ACH_LIM equals iach.REF_IND
                            join cach in _dbContext.TJ_CIRs on dem.REF_CTR_DEM_LIM equals cach.REF_CTR_CIR
                           join ctr in _dbContext.T_CONTRATs on dem.REF_CTR_DEM_LIM equals ctr.REF_CTR
                            where (cach.ID_ROLE_CIR == "ACH" && cach.REF_IND_CIR == dem.REF_ACH_LIM
                                                             && dem.ACTIF_DEM_LIMI == false
                                                             && dem.DECISION_LIM != "RF"
                                                             && dem.MONT_ACC != null)
                                                           //  && (dem.COMMENT != null && dem.COMMENT != ""))
                            select new T_DEM_LIMITE_DTO
                            {
                                REF_CTR_DEM_LIM = dem.REF_CTR_DEM_LIM,
                                REF_ACH_LIM = dem.REF_ACH_LIM,
                                ACTIF_DEM_LIMI = dem.ACTIF_DEM_LIMI,
                                DAT_DEM_LIM = dem.DAT_DEM_LIM,
                                REF_DEM_LIM = dem.REF_DEM_LIM,
                                DELAIS_DEM_LIM = dem.DELAIS_DEM_LIM,
                                DEVISE = dem.DEVISE,
                                MODE_PAY_DEM_LIM = dem.MODE_PAY_DEM_LIM,
                                //MODE_PAY_DEM_LIM = DisplayTextWithoutAbr(dem.MODE_PAY_DEM_LIM),
                                //TYP_DEM_LIM = DisplayTextWithoutAbr(dem.TYP_DEM_LIM),
                                //MODE_PAY_ACC = DisplayTextWithoutAbr(dem.MODE_PAY_ACC),
                                MONT_DEM_LIM = (decimal)dem.MONT_DEM_LIM,
                                SORT_DEM_LIM = dem.SORT_DEM_LIM,
                                TYP_DEM_LIM = dem.TYP_DEM_LIM,
                                DELAIS_ACC = dem.DELAIS_ACC,
                                MONT_ACC = (decimal)dem.MONT_ACC,
                                MODE_PAY_ACC = dem.MODE_PAY_ACC,
                            }).AsQueryable();

                        var result = await PagedList<T_DEM_LIMITE_DTO>.CreateAsync(demLim, paginationParam.PageNumber, paginationParam.PageSize);

                        return result;
                    }

  public async Task<PagedList<T_DEM_LIMITE>> getAllLDemLimites(PaginationParams paginationParams)
    { 
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<T_DEM_LIMITE>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task<T_DEM_LIMITE> validateLimite(int id)
    {
        var limite = await  base.Table.FirstOrDefaultAsync(p => p.REF_DEM_LIM == id);
       if (limite == null)
        {
            throw new InvalidOperationException($"Limite with id {id} not found");

        }
        limite.DECISION_LIM = "V";
        limite.ACTIF_DEM_LIMI = true;
       await base.UpdateAsync(limite);
        return limite;
        
    }

    public  async Task<bool> UpdateDemandeLimiteAsync(int demandeLimiteId, T_DEM_LIMITE updatedDemandeLimite)
    {
        var existingDemandeLimite = await base.Table.FirstOrDefaultAsync(p => p.REF_DEM_LIM == updatedDemandeLimite.REF_DEM_LIM);

        if (existingDemandeLimite == null)
        {
            throw new InvalidOperationException($"Demande limite with REF_DEM_LIM {updatedDemandeLimite.REF_DEM_LIM} not found");
        }

        await base.UpdateAsync(existingDemandeLimite);

        return true;    
    }

    public Task<T_DEM_LIMITE> GetDemandeLimiteByRefCtrAndType(int id, string type)
    {
        throw new NotImplementedException();
    }

    public async Task<T_DEM_LIMITE> GetDemLimiteById(int id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.REF_DEM_LIM == id);

    }
    
}