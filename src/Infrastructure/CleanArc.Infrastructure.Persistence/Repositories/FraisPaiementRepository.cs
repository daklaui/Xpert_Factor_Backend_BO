using System;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class FraisPaiementRepository : BaseAsyncRepository<T_FRAIS_PAIEMENT>, IFraisPaiementRepository
    {
        private ApplicationDbContext _dbContext;

        public FraisPaiementRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddFraisPaiementAsync(T_FRAIS_PAIEMENT fraisPaiement)
        {
            await base.AddAsync(fraisPaiement);
        }

        public Task<PagedList<T_FRAIS_PAIEMENT>> GetAllFraisPaiementAsync(PaginationParams paginationParams)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T_FRAIS_PAIEMENT>> GetFraisPaiementById(int id)
        {
            return await base.TableNoTracking.Where(p => p.REF_CTR_FRAIS_PAIE == id).ToListAsync();
        }    
        
        public async Task<T_FRAIS_PAIEMENT> GetFraisPaiementByRefCtrAndType(int id, string type)
        {
            return await base.TableNoTracking.FirstAsync(p => p.REF_CTR_FRAIS_PAIE == id && p.TYP_FRAIS_PAIE == type);
        }

        public async Task<bool> UpdateFraisPaiementAsync(int fraisPaiementId, T_FRAIS_PAIEMENT updatedFraisPaiement)
        {
            var existingFraisPaiement = await base.Table.FirstOrDefaultAsync(p => p.REF_CTR_FRAIS_PAIE == updatedFraisPaiement.REF_CTR_FRAIS_PAIE && p.TYP_FRAIS_PAIE == updatedFraisPaiement.TYP_FRAIS_PAIE);

            if (existingFraisPaiement == null)
            {
                throw new InvalidOperationException($"Frais paiement with ref_ctr {updatedFraisPaiement.REF_CTR_FRAIS_PAIE} and type {updatedFraisPaiement.TYP_FRAIS_PAIE} not found");
            }

            await base.UpdateAsync(existingFraisPaiement);

            return true;
        }
    }
}