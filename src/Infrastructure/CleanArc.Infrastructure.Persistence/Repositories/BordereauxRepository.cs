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

        public async Task<PagedList<T_BORDEREAU>> GetAllBordereauxAsync(PaginationParams paginationParams)
        {
           
            var query = base.TableNoTracking.AsQueryable();

            var result = await PagedList<T_BORDEREAU>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

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
            
            foreach (var detBord in detBordList)
            {
                detBord.VALIDE_DET_BORD = true;
                _dbContext.Entry(detBord).State = EntityState.Modified;
            }
            
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task<List<BordereauxWithIndividuDto>> GetDetailsBordByRefCtrAsync(int refCtr)
        {
            // Get the current year
            var currentYear = DateTime.Now.Year.ToString();

            // Retrieve the maximum NUM_BORD for the specified REF_CTR_BORD
            var maxNumBord = await _dbContext.T_BORDEREAUs
                .Where(bord => bord.REF_CTR_BORD == refCtr)
                .MaxAsync(bord => bord.NUM_BORD);

            // Increment the maximum NUM_BORD by 1
            var newNumBord = (int.Parse(maxNumBord) + 1).ToString();

            // Retrieve the required details
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
                    NUM_BORD = newNumBord, // Use the new incremented NUM_BORD
                    ANNEE_BORD = currentYear, // Use the current year
                    NOM_IND = joined.ind.NOM_IND,
                    REF_IND_CIR = joined.cir.REF_IND_CIR // Include REF_IND_CIR
                })
                .Distinct()
                .ToListAsync();

            return result;
        }
        


    }
}