using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;


namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class IndividuRepository : BaseAsyncRepository<T_INDIVIDU>, IIndividualRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public IndividuRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddIndividualDTOAsync(IndividualDTO individualDTO)
        {
            await _dbContext.T_INDIVIDUs.AddAsync(individualDTO.Individu);

            if (individualDTO.TrRibs != null)
            {
                await _dbContext.TR_RIBs.AddRangeAsync(individualDTO.TrRibs);
            }

            if (individualDTO.Contacts != null)
            {
                await _dbContext.T_CONTACTs.AddRangeAsync(individualDTO.Contacts);
            }

            if (individualDTO.TsUsers != null)
            {
                await _dbContext.TS_USERS_WEBs.AddAsync(individualDTO.TsUsers);
            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task<PagedList<T_INDIVIDU>> GetAllIndividusAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<T_INDIVIDU>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<PageInfo<IndividualDTO>> GetAllIndividualDTOsAsync(PaginationParams paginationParams)
        {
            var individusQuery = _dbContext.T_INDIVIDUs.AsQueryable();

            var totalCount = await individusQuery.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalCount / paginationParams.PageSize);

            var individus = await individusQuery
                .OrderBy(i => i.REF_IND)
                .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
                .Take(paginationParams.PageSize)
                .ToListAsync();

            var individualDTOs = individus.Select(i => new IndividualDTO
            {
                Individu = i,
                TrRibs = _dbContext.TR_RIBs.Where(r => r.REF_IND_RIB == i.REF_IND).ToList(),
                Contacts = _dbContext.T_CONTACTs.Where(c => c.REF_IND_CONTACT == i.REF_IND).ToList(),
                TsUsers = _dbContext.TS_USERS_WEBs.FirstOrDefault(u => u.REF_IND_WEB == i.REF_IND)
            }).ToList();

            return new PageInfo<IndividualDTO>
            {
                PageSize = paginationParams.PageSize,
                CurrentPage = paginationParams.PageNumber,
                TotalPages = totalPages,
                TotalCount = totalCount,
                Result = individualDTOs
            };
        }

        public async Task<IndividualDTO> GetIndividuByIdAsync(int id)
        {
      
            var individu = await _dbContext.T_INDIVIDUs.FirstOrDefaultAsync(i => i.REF_IND == id);
    
            if (individu == null)
            {
                return null;
            }

           
            var trRibs = await _dbContext.TR_RIBs.Where(r => r.REF_IND_RIB == id).ToListAsync();
            var contacts = await _dbContext.T_CONTACTs.Where(c => c.REF_IND_CONTACT == id).ToListAsync();
            var tsUsers = await _dbContext.TS_USERS_WEBs.FirstOrDefaultAsync(u => u.REF_IND_WEB == id);

            // Map to IndividualDTO
            var individualDTO = new IndividualDTO
            {
                Individu = individu,
                TrRibs = trRibs,
                Contacts = contacts,
                TsUsers = tsUsers
            };

            return individualDTO;
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
        public async Task<List<AdherentDto>> GetAllAdherentsAsync()
        {
            var adherents = await _dbContext.T_INDIVIDUs
                .Join(_dbContext.TJ_CIRs,
                    individu => individu.REF_IND,
                    cir => cir.REF_IND_CIR,
                    (individu, cir) => new { individu.REF_IND, individu.NOM_IND, cir.ID_ROLE_CIR })
                .Where(joined => joined.ID_ROLE_CIR == "ADH")
                .Select(joined => new AdherentDto { RefInd = joined.REF_IND, NomInd = joined.NOM_IND })
                .ToListAsync();

            return adherents;
        }
        public async Task<List<int>> GetRefCtrCirByRefIndAsync(int refInd)
        {
            var result = await _dbContext.T_INDIVIDUs
                .Join(_dbContext.TJ_CIRs,
                    individu => individu.REF_IND,
                    cir => cir.REF_IND_CIR,
                    (individu, cir) => new { individu, cir })
                .Where(joined => joined.cir.ID_ROLE_CIR == "ADH" && joined.cir.REF_IND_CIR == refInd)
                .Select(joined => joined.cir.REF_CTR_CIR)
                .ToListAsync();

            return result;
        }
        public async Task<PagedList<NomIndividuDto>> GetAllNomIndivAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable()
                .Select(ind => new NomIndividuDto { RefInd = ind.REF_IND, NomInd = ind.NOM_IND });

            var result =
                await PagedList<NomIndividuDto>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }
         public async Task<List<AdherentDetailDto>> GetAdherentDetailsByAdherentAsync(int refIndiv)
         {
             var adherentDetails = await _dbContext.TJ_CIRs
                 .Where(cir => cir.ID_ROLE_CIR == "ach" && cir.REF_IND_CIR==refIndiv)  
                 .Join(_dbContext.T_INDIVIDUs,
                     cir => cir.REF_IND_CIR,
                     individu => individu.REF_IND,
                     (cir, individu) => new AdherentDetailDto
                     {
                         RefInd = individu.REF_IND,
                         NomInd = individu.NOM_IND,
                         TypDocIdInd = individu.TYP_DOC_ID_IND,
                         NumDocIdInd = individu.NUM_DOC_ID_IND
                     })
                 .ToListAsync();

             return adherentDetails;
         }
       
         public async Task<List<NomIndividuDto>> GetIndividusSansContrat(int refctr)
         {
             var individusSansContrat = await base.Table
                 .Where(individu =>
                     !_dbContext.TJ_CIRs.Any(cir =>
                         cir.REF_IND_CIR == individu.REF_IND && cir.REF_CTR_CIR == refctr && cir.ID_ROLE_CIR=="ACH"))
                 .Select(individu => new NomIndividuDto
                 {
                     RefInd = individu.REF_IND,
                     NomInd = individu.NOM_IND
                 })
                 .ToListAsync();

             return individusSansContrat;
         }

         
         
         
         
         
         

         

    }
}
