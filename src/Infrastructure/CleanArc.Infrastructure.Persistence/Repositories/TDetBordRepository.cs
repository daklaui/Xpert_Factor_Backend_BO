using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class TDetBordRepository :BaseAsyncRepository<T_DET_BORD> ,IT_DET_BORD_Repository
{
    private readonly ApplicationDbContext _dbContext;

    public TDetBordRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
      
    }

    public async Task addT_DET_BORD_Async(T_DET_BORD detBord)
    {
        await base.AddAsync(detBord);
    }

    public async Task<PagedList<T_DET_BORD>> GetAllT_DET_BORD_Async(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();

        var result = await PagedList<T_DET_BORD>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

        return result;
    }

    public async Task<T_DET_BORD> GetT_DET_BORD_Byid(string id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_DET_BORD == id);
    }

    public async Task<IEnumerable<T_DET_BORD>> GetDetBordByPK(string numBord, int refCtr , string yearBord)
    {
        var query =base.TableNoTracking.Where(x => 
            x.NUM_BORD == numBord && 
            x.REF_CTR_DET_BORD == refCtr && 
            x.ANNEE_BORD == yearBord);

        return await query.ToListAsync();
    }

    public async Task<int> getMaxDocs()
    {
        return base.TableNoTracking.Select(p => Convert.ToInt32(p.ID_DET_BORD)).DefaultIfEmpty().Max();
    }

    public async Task<bool> UpdateDetBordAsync(PksDetBordDto pksDto, T_DET_BORD updatedDetBord)
    {
    
    var existingDetBordList = await GetDetBordByPK(pksDto.NUM_BORD, pksDto.REF_CTR_DET_BORD, pksDto.ANNEE_BORD);
    
   
    if (existingDetBordList == null || !existingDetBordList.Any())
    {
        throw new InvalidOperationException($"DetBord with primary key (NUM_BORD: {pksDto.NUM_BORD}, REF_CTR_DET_BORD: {pksDto.REF_CTR_DET_BORD}, ANNEE_BORD: {pksDto.ANNEE_BORD}) not found.");
    }

   
    foreach (var existingDetBord in existingDetBordList)
    {
       
        existingDetBord.TYP_DET_BORD = updatedDetBord.TYP_DET_BORD;
        existingDetBord.NUM_CREANCE_ASS_BORD = updatedDetBord.NUM_CREANCE_ASS_BORD;
        existingDetBord.TYP_ASS_DET_BORD = updatedDetBord.TYP_ASS_DET_BORD;
        existingDetBord.DAT_DET_BORD = updatedDetBord.DAT_DET_BORD;
        existingDetBord.MONT_TTC_DET_BORD = updatedDetBord.MONT_TTC_DET_BORD;
        existingDetBord.DEVISE_DET_BORD = updatedDetBord.DEVISE_DET_BORD;
        existingDetBord.ECH_DET_BORD = updatedDetBord.ECH_DET_BORD;
        existingDetBord.ECH_APR_PROROG_DET_BORD = updatedDetBord.ECH_APR_PROROG_DET_BORD;
        existingDetBord.MONT_OUV_DET_BORD = updatedDetBord.MONT_OUV_DET_BORD;
        existingDetBord.DELAI_PAIE_DET_BORD = updatedDetBord.DELAI_PAIE_DET_BORD;
        existingDetBord.MODE_REG_DET_BORD = updatedDetBord.MODE_REG_DET_BORD;
        existingDetBord.TYP_REG_DET_BORD = updatedDetBord.TYP_REG_DET_BORD;
        existingDetBord.TX_FDG_DET_BORD = updatedDetBord.TX_FDG_DET_BORD;
        existingDetBord.TX_COMM_FACT_DET_BORD = updatedDetBord.TX_COMM_FACT_DET_BORD;
        existingDetBord.ANNUL_DET_BORD = updatedDetBord.ANNUL_DET_BORD;
        existingDetBord.VALIDE_DET_BORD = updatedDetBord.VALIDE_DET_BORD;
        existingDetBord.REF_IND_DET_BORD = updatedDetBord.REF_IND_DET_BORD;
        existingDetBord.MONT_FDG_DET_BORD = updatedDetBord.MONT_FDG_DET_BORD;
        existingDetBord.MONT_FDG_LIBERE_DET_BORD = updatedDetBord.MONT_FDG_LIBERE_DET_BORD;
        existingDetBord.MONT_COMM_FACT_DET_BORD = updatedDetBord.MONT_COMM_FACT_DET_BORD;
        existingDetBord.TX_TVA_COMM_FACT_DET_BORD = updatedDetBord.TX_TVA_COMM_FACT_DET_BORD;
        existingDetBord.MONT_TVA_COMM_FACT_DET_BORD = updatedDetBord.MONT_TVA_COMM_FACT_DET_BORD;
        existingDetBord.MONT_TTC_COMM_FACT_DET_BORD = updatedDetBord.MONT_TTC_COMM_FACT_DET_BORD;
        existingDetBord.ID_CALC_DISPO_DET_BORD = updatedDetBord.ID_CALC_DISPO_DET_BORD;
        existingDetBord.REF_DET_BORD = updatedDetBord.REF_DET_BORD;
        existingDetBord.COMM_DET_BORD = updatedDetBord.COMM_DET_BORD;
        existingDetBord.RETENU_DET_BORD = updatedDetBord.RETENU_DET_BORD;

        
        _dbContext.Entry(existingDetBord).State = EntityState.Modified;
    }
    await _dbContext.SaveChangesAsync();
    return true;
}


    public async  Task DeleteT_DET_BORD(T_DET_BORD detBord)
   {
       _dbContext.Set<T_DET_BORD>().Remove(detBord);
   }

    public async Task<IEnumerable<DetailsDetBordDto>> getDetailsDetBord(PksDetBordDto pksDto)
   {
       string sqlQuery = $@"
                SELECT 
         ID_DET_BORD,
    NUM_BORD,
    (SELECT REF_DOCUMENT_DET_BORD FROM TJ_DOCUMENT_DET_BORD WHERE ID_DET_BORD = T_DET_BORD.ID_DET_BORD) AS REF_DOCUMENT_DET_BORD,
    TYP_DET_BORD,
    DAT_DET_BORD,
    MONT_TTC_DET_BORD,
    ANNEE_BORD,
    REF_CTR_DET_BORD,
    ECH_DET_BORD,
    MODE_REG_DET_BORD,
    (SELECT NOM_IND FROM T_INDIVIDU WHERE REF_IND = REF_IND_DET_BORD) AS NOM_IND,
    REF_CTR_PAPIER_CTR
FROM
    T_DET_BORD
    JOIN T_CONTRAT ON T_CONTRAT.REF_CTR = T_DET_BORD.REF_CTR_DET_BORD
                WHERE
                    NUM_BORD = '{pksDto.NUM_BORD}' AND
                    REF_CTR_DET_BORD = {pksDto.REF_CTR_DET_BORD} AND
                    ANNEE_BORD = '{pksDto.ANNEE_BORD}' AND
                    VALIDE_DET_BORD = 0;
            ";
       var result = await _dbContext.DetailsDetBordDto.FromSqlRaw(sqlQuery).ToListAsync();

 
       return result;
   }
}
