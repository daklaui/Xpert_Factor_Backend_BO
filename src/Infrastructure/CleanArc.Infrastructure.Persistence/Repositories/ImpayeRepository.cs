using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class ImpayeRepository :BaseAsyncRepository<T_IMPAYE>,IimpayeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ImpayeRepository(ApplicationDbContext dbContext):base(dbContext)
    {
        _dbContext = dbContext;
    }
 
    public async Task AddImpayeAsync(T_IMPAYE impaye)
    {
        await base.AddAsync(impaye);

    }

    public async Task<PagedList<T_IMPAYE_DTO>> getListOfImpaye(PaginationParams paginationParam)
    {
        var impayes = (from impaye in _dbContext.T_IMPAYEs
            join enc in _dbContext.T_ENCAISSEMENTs on impaye.ID_ENC_IMP equals enc.ID_ENC
            join adh in _dbContext.T_INDIVIDUs on enc.REF_ADH_ENC equals adh.REF_IND
            join ach in _dbContext.T_INDIVIDUs on enc.REF_ACH_ENC equals ach.REF_IND
            where impaye.ID_ENC_IMP == enc.ID_ENC 
            select new T_IMPAYE_DTO
            {
                ID_ENC_IMP = impaye.ID_ENC_IMP,
                MONT_IMP = impaye.MONT_IMP,
                DATE_IMP = impaye.DATE_IMP,
                DATE_SAISI_IMP = impaye.DATE_SAISI_IMP,
                TYP_ENC = enc.TYP_ENC,
                NOM_IND = adh.NOM_IND, 
                ADR_IND = ach.ADR_IND  
            }).AsQueryable();

        var result = await PagedList<T_IMPAYE_DTO>.CreateAsync(impayes, paginationParam.PageNumber, paginationParam.PageSize);

        return result;
    }

}