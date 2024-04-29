using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class IndividuRepository : BaseAsyncRepository<T_INDIVIDU>, IIndividualRepository
{
    private IIndividualRepository _individualRepositoryImplementation;
    private IIndividualRepository _individualRepositoryImplementation1;

    public IndividuRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddIIndividualAsync(T_INDIVIDU individu)
    {
        await base.AddAsync(individu);
    }

    

    public  async Task<PagedList<T_INDIVIDU>> GetAllIndividusAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<T_INDIVIDU>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task<T_INDIVIDU> GetIndividuById(int id)
    {
          return await base.TableNoTracking.FirstAsync(p=>p.REF_IND == id);
    }
    
    public async Task<bool> UpdateIndividuAsync(int id, T_INDIVIDU updatedIndividu)
{
    var existingIndividu = await base.Table.FirstOrDefaultAsync(e => e.REF_IND == id);

    if (existingIndividu == null)
    {
        throw new InvalidOperationException($"Individu with id {id} not found");
    }

    
    existingIndividu.GENRE_IND = updatedIndividu.GENRE_IND;
    existingIndividu.TYP_DOC_ID_IND = updatedIndividu.TYP_DOC_ID_IND;
    existingIndividu.NUM_DOC_ID_IND = updatedIndividu.NUM_DOC_ID_IND;
    existingIndividu.LIEU_DOC_ID_IND = updatedIndividu.LIEU_DOC_ID_IND;
    existingIndividu.DATE_DOC_ID_IND = updatedIndividu.DATE_DOC_ID_IND;
    existingIndividu.COD_TVA_IND = updatedIndividu.COD_TVA_IND;
    existingIndividu.NOM_IND = updatedIndividu.NOM_IND;
    existingIndividu.PRE_IND = updatedIndividu.PRE_IND;
    existingIndividu.DAT_NAISS_CREAT = updatedIndividu.DAT_NAISS_CREAT;
    existingIndividu.GRP_IND = updatedIndividu.GRP_IND;
    existingIndividu.LIM_CRED_GLO_IND = updatedIndividu.LIM_CRED_GLO_IND;
    existingIndividu.LIM_FIN_GLO_IND = updatedIndividu.LIM_FIN_GLO_IND;
    existingIndividu.INFO_IND = updatedIndividu.INFO_IND;
    existingIndividu.DAT_INFO_IND = updatedIndividu.DAT_INFO_IND;
    existingIndividu.ID_NLDP = updatedIndividu.ID_NLDP;
    existingIndividu.COD_SCLAS = updatedIndividu.COD_SCLAS;
    existingIndividu.ABRV_IND = updatedIndividu.ABRV_IND;
    existingIndividu.LOGO_IND = updatedIndividu.LOGO_IND;
    existingIndividu.PHOTO_IND = updatedIndividu.PHOTO_IND;
    existingIndividu.MF_IND = updatedIndividu.MF_IND;
    existingIndividu.RC_IND = updatedIndividu.RC_IND;
    existingIndividu.EXO_TVA = updatedIndividu.EXO_TVA;
    existingIndividu.DAT_DEB_EXO = updatedIndividu.DAT_DEB_EXO;
    existingIndividu.DAT_FIN_EXO = updatedIndividu.DAT_FIN_EXO;
    existingIndividu.TEL_IND = updatedIndividu.TEL_IND;
    existingIndividu.FAX_IND = updatedIndividu.FAX_IND;
    existingIndividu.EMAIL_IND = updatedIndividu.EMAIL_IND;
    existingIndividu.REF_ADH_IND = updatedIndividu.REF_ADH_IND;
    existingIndividu.FROM_JUR_IND = updatedIndividu.FROM_JUR_IND;
    existingIndividu.EXO_IND = updatedIndividu.EXO_IND;
    existingIndividu.ADR_IND = updatedIndividu.ADR_IND;
    existingIndividu.CP_IND = updatedIndividu.CP_IND;
    existingIndividu.REF_ACH_IND = updatedIndividu.REF_ACH_IND;
    existingIndividu.ID_GROUPE = updatedIndividu.ID_GROUPE;

    await base.UpdateAsync(existingIndividu);

    return true;
}

}