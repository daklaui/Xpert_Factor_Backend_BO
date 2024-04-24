using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class ContratRepository : BaseAsyncRepository<T_CONTRAT>, IContratRepository
    {
        public ContratRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddContratAsync(T_CONTRAT contrat)
        {
            await base.AddAsync(contrat);
        }

        public async Task<PagedList<T_CONTRAT>> GetAllContratsAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<T_CONTRAT>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<T_CONTRAT> GetContratById(int id)
        {
            return await base.TableNoTracking.FirstAsync(p => p.REF_CTR == id);
        }

        public async Task<bool> UpdateContratAsync(int id, T_CONTRAT updatedContrat)
        {
            var existingContrat = await base.Table.FirstOrDefaultAsync(e => e.REF_CTR == id);

            if (existingContrat == null)
            {
                throw new InvalidOperationException($"Contrat with id {id} not found");
            }

            existingContrat.STATUT_CTR = updatedContrat.STATUT_CTR;
            existingContrat.REF_CTR_PAPIER_CTR = updatedContrat.REF_CTR_PAPIER_CTR;
            existingContrat.SERVICE_CTR = updatedContrat.SERVICE_CTR;
            existingContrat.TYP_CTR = updatedContrat.TYP_CTR;
            existingContrat.DAT_SIGN_CTR = updatedContrat.DAT_SIGN_CTR;
            existingContrat.DAT_DEB_CTR = updatedContrat.DAT_DEB_CTR;
            existingContrat.DAT_RESIL_CTR = updatedContrat.DAT_RESIL_CTR;
            existingContrat.DAT_PROCH_VERS_CTR = updatedContrat.DAT_PROCH_VERS_CTR;
            existingContrat.CA_CTR = updatedContrat.CA_CTR;
            existingContrat.CA_EXP_CTR = updatedContrat.CA_EXP_CTR;
            existingContrat.CA_IMP_CTR = updatedContrat.CA_IMP_CTR;
            existingContrat.LIM_FIN_CTR = updatedContrat.LIM_FIN_CTR;
            existingContrat.DEVISE_CTR = updatedContrat.DEVISE_CTR;
            existingContrat.NB_ACH_PREVU_CTR = updatedContrat.NB_ACH_PREVU_CTR;
            existingContrat.NB_FACT_PREVU_CTR = updatedContrat.NB_FACT_PREVU_CTR;
            existingContrat.NB_AVOIRS_PREVU_CTR = updatedContrat.NB_AVOIRS_PREVU_CTR;
            existingContrat.NB_REMISES_PREVU_CTR = updatedContrat.NB_REMISES_PREVU_CTR;
            existingContrat.DELAI_MOYEN_REG_CTR = updatedContrat.DELAI_MOYEN_REG_CTR;
            existingContrat.DELAI_MAX_REG_CTR = updatedContrat.DELAI_MAX_REG_CTR;
            existingContrat.FACT_REG_CTR = updatedContrat.FACT_REG_CTR;
            existingContrat.DERN_MONT_DISP_2 = updatedContrat.DERN_MONT_DISP_2;
            existingContrat.MIN_COMM_FACT = updatedContrat.MIN_COMM_FACT;
            existingContrat.IS_NOTIFIED = updatedContrat.IS_NOTIFIED;
            existingContrat.OLD_STATUT_CTR = updatedContrat.OLD_STATUT_CTR;
            existingContrat.DAT_CREATION_CTR = updatedContrat.DAT_CREATION_CTR;
            existingContrat.RESP_CTR_1 = updatedContrat.RESP_CTR_1;
            existingContrat.RESP_CTR_2 = updatedContrat.RESP_CTR_2;

            await base.UpdateAsync(existingContrat);

            return true;
        }

        public async Task<int> GetContractsForCurrentYearasync()
        {
            int currentYear = DateTime.Now.Year;

            var numberCtr = await Task.Run(() =>
            {
                return base.Table
                    .Where(c => c.DAT_CREATION_CTR.HasValue && c.DAT_CREATION_CTR.Value.Year == currentYear)
                    .Count();
            });

            return numberCtr;
        }

      

    }
}
