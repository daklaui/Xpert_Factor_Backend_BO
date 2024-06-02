using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class BordereauxRepository : BaseAsyncRepository<T_BORDEREAU>, IBordereauxRepository
    {
        private readonly ApplicationDbContext _dbContext;
      

        public BordereauxRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            
        }

        public async Task addBordereauxAsync(T_BORDEREAU bordereau)
        {
            await base.AddAsync(bordereau);
        }

        public async Task<PagedList<GetAllBordDTO>> GetAllBordereauxAsync(PaginationParams paginationParams)
        {
            var query = from bord in _dbContext.T_BORDEREAUs.AsQueryable()
                join ctr in _dbContext.T_CONTRATs.AsQueryable() on bord.REF_CTR_BORD equals ctr.REF_CTR
               
                select new GetAllBordDTO
                {
                    NUM_BORD = bord.NUM_BORD,
                    REF_CTR_BORD = bord.REF_CTR_BORD,
                    NB_DOC_BORD = bord.NB_DOC_BORD,
                    ANNEE_BORD = bord.ANNEE_BORD,
                    DAT_SAISIE_BORD = bord.DAT_SAISIE_BORD,
                    Nbre_Det = _dbContext.T_DET_BORDs.Count(det => det.NUM_BORD == bord.NUM_BORD && det.ANNEE_BORD == bord.ANNEE_BORD && det.REF_CTR_DET_BORD == bord.REF_CTR_BORD),
                    Nom_ADH = _dbContext.T_INDIVIDUs.Where(ind => ind.REF_IND == bord.REF_ADH_BORD).Select(ind => ind.NOM_IND).FirstOrDefault(),
                    MontantTotale = _dbContext.T_DET_BORDs.Where(det => det.NUM_BORD == bord.NUM_BORD && det.ANNEE_BORD == bord.ANNEE_BORD && det.REF_CTR_DET_BORD == bord.REF_CTR_BORD).Sum(det => det.MONT_TTC_DET_BORD) ?? 0,
                    REF_CTR_PAPIER_CTR = bord.REF_CTR_BORD
                };

            var result = await PagedList<GetAllBordDTO>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<T_BORDEREAU> GetBordereauxById(string id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.NUM_BORD == id); // Assuming Id property
        }       
        
        public async Task<T_BORDEREAU> GetBordereauxByPK(string numBord, int refCtr , string yearBord)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.NUM_BORD == numBord && p.ANNEE_BORD == yearBord && p.REF_CTR_BORD == refCtr); // Assuming Id property
        }


        public async Task DeleteBordereaux(T_BORDEREAU bordereau)
        {
            _dbContext.Set<T_BORDEREAU>().Remove(bordereau);
        }
        public async Task<bool> UpdateBordereauxAsync(PksBordereauxDto pksDto, T_BORDEREAU updatedBordereau)
        {
           
            var existingBordereau = await GetBordereauxByPK(pksDto.NUM_BORD, pksDto.REF_CTR_BORD, pksDto.ANNEE_BORD);

           
            if (existingBordereau == null)
            {
                throw new InvalidOperationException($"Bordereau with primary key (NUM_BORD: {pksDto.NUM_BORD}, REF_CTR_BORD: {pksDto.REF_CTR_BORD}, ANNEE_BORD: {pksDto.ANNEE_BORD}) not found.");
            }
            existingBordereau.REF_ADH_BORD = updatedBordereau.REF_ADH_BORD;
            existingBordereau.REF_ACH_BORD = updatedBordereau.REF_ACH_BORD;
            existingBordereau.DAT_BORD = updatedBordereau.DAT_BORD;
            existingBordereau.NB_DOC_BORD = updatedBordereau.NB_DOC_BORD;
            existingBordereau.MONT_TOT_BORD = updatedBordereau.MONT_TOT_BORD;
            existingBordereau.DEVISE_ACH = updatedBordereau.DEVISE_ACH;
            existingBordereau.SOLDE_BORD = updatedBordereau.SOLDE_BORD;
            existingBordereau.VALIDE_BORD = updatedBordereau.VALIDE_BORD;
            existingBordereau.DAT_SAISIE_BORD = updatedBordereau.DAT_SAISIE_BORD;
            existingBordereau.EMETTEUR = updatedBordereau.EMETTEUR;
            _dbContext.Entry(existingBordereau).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task ValidateBordereauAsync(T_BORDEREAU existingBordereau, List<T_DET_BORD> detBordList)
        {
            existingBordereau.VALIDE_BORD = true;
            _dbContext.Entry(existingBordereau).State = EntityState.Modified;

            string x = "F";
            var f = await _dbContext.T_FOND_GARANTIEs
                .Where(p => p.REF_CTR_FDG == existingBordereau.REF_CTR_BORD && p.TYP_FDG == x)
                .FirstOrDefaultAsync();

            var cf = await _dbContext.T_COMM_FACTORINGs
                .Where(p => p.REF_CTR_COMM_FACTORING == existingBordereau.REF_CTR_BORD && p.TYP_COMM_FACTORING == x)
                .FirstOrDefaultAsync();

            if (cf.TX_COMM_FACTORING.ToString() == "")
            {
                cf.TX_COMM_FACTORING = 0;
            }

            if (f.TX_FDG.ToString() == "")
            {
                f.TX_FDG = 0;
            }

            decimal TX_COMM_FACTORING =
                ParseDecimalOrDefault(cf.TX_COMM_FACTORING.ToString().Replace(" ", "").Replace(",", "."));
            TX_COMM_FACTORING = TX_COMM_FACTORING / 100;
            decimal TX_FDG = ParseDecimalOrDefault(f.TX_FDG.ToString().Replace(" ", "").Replace(",", "."));
            TX_FDG = TX_FDG / 100;
            decimal ITauxFDGF = ParseDecimalOrDefault(f.TX_FDG.ToString().Replace(" ", "").Replace(",", "."));

            decimal mONT_MIN_DOC_COMM_FACTORING;
            try
            {
                mONT_MIN_DOC_COMM_FACTORING =
                    ParseDecimalOrDefault(cf.MONT_MIN_DOC_COMM_FACTORING.ToString().Replace(" ", "").Replace(",", "."));
            }
            catch (Exception e)
            {
                mONT_MIN_DOC_COMM_FACTORING = 0;
            }

            decimal TauxTVA = 0.19M;

            foreach (var detBord in detBordList)
            {
                detBord.VALIDE_DET_BORD = true;
                _dbContext.Entry(detBord).State = EntityState.Modified;

                decimal V_IMTCOMFAC = TX_COMM_FACTORING * (decimal)detBord.MONT_TTC_DET_BORD;
                decimal IMTCOMFAC = mONT_MIN_DOC_COMM_FACTORING > V_IMTCOMFAC
                    ? mONT_MIN_DOC_COMM_FACTORING
                    : V_IMTCOMFAC;
                decimal IMtTVACOM = TauxTVA * IMTCOMFAC;
                decimal IMTCOMTTC = IMTCOMFAC + IMtTVACOM;

                detBord.TX_FDG_DET_BORD = ParseDecimalOrDefault(f.TX_FDG.ToString().Replace(" ", "").Replace(",", "."));
                detBord.TX_COMM_FACT_DET_BORD =
                    ParseDecimalOrDefault(cf.TX_COMM_FACTORING.ToString().Replace(" ", "").Replace(",", "."));
                decimal MONT_FDG_DET_BORD = TX_FDG * (decimal)detBord.MONT_TTC_DET_BORD;
                detBord.MONT_FDG_LIBERE_DET_BORD = 0;
                detBord.MONT_FDG_DET_BORD = Math.Round(MONT_FDG_DET_BORD, 3);
                detBord.MONT_COMM_FACT_DET_BORD = IMTCOMFAC;
                detBord.TX_TVA_COMM_FACT_DET_BORD = TauxTVA;
                detBord.MONT_TVA_COMM_FACT_DET_BORD = IMtTVACOM;
                detBord.MONT_TTC_COMM_FACT_DET_BORD = IMTCOMTTC;
            }

            await _dbContext.SaveChangesAsync();
        }

        private decimal ParseDecimalOrDefault(string value)
        {
            if (decimal.TryParse(value, out var result))
            {
                return result;
            }

            return 0;
        }
        
        public async Task<List<BordereauxWithIndividuDto>> GetDetailsBordByRefCtrAsync(int refCtr)
        {
            var currentYear = DateTime.Now.Year.ToString();
            var numBordList = await _dbContext.T_BORDEREAUs
                .Where(bord => bord.REF_CTR_BORD == refCtr)
                .Select(bord => bord.NUM_BORD)
                .ToListAsync();
            
            var maxNumBord = numBordList
                .Select(numBord => int.TryParse(numBord, out var num) ? num : 0)
                .Max();

            var newNumBord = (maxNumBord + 1).ToString();

            var result = await _dbContext.T_BORDEREAUs
                .Join(_dbContext.T_CONTRATs,
                    bord => bord.REF_CTR_BORD,
                    ctr => ctr.REF_CTR,
                    (bord, ctr) => new { bord, ctr })
                .Join(_dbContext.TJ_CIRs,
                    joined => joined.bord.REF_CTR_BORD,
                    cir => cir.REF_CTR_CIR,
                    (joined, cir) => new { joined.bord, joined.ctr, cir })
                .Join(_dbContext.T_INDIVIDUs,
                    joined => joined.cir.REF_IND_CIR,
                    ind => ind.REF_IND,
                    (joined, ind) => new { joined.bord, joined.ctr, joined.cir, ind })
                .Where(joined => joined.bord.REF_CTR_BORD == refCtr && joined.cir.ID_ROLE_CIR == "ACH")
                .Select(joined => new BordereauxWithIndividuDto
                {
                    REF_CTR_BORD = joined.bord.REF_CTR_BORD,
                    NUM_BORD = newNumBord,
                    ANNEE_BORD = currentYear,
                    NOM_IND = joined.ind.NOM_IND,
                    REF_IND_CIR = joined.cir.REF_IND_CIR
                })
                .Distinct()
                .ToListAsync();

            return result;
        }
        


    }
}