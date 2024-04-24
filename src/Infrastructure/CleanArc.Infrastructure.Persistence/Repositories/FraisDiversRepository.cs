using System;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class FraisDiversRepository : BaseAsyncRepository<T_FRAIS_DIVERS>, IFraisDiversRepository
    {
        public FraisDiversRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddFraisDiversAsync(T_FRAIS_DIVERS fraisDivers)
        {
            await base.AddAsync(fraisDivers);
        }
         
        public async Task<PagedList<T_FRAIS_DIVERS>> GetAllFraisDiversAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<T_FRAIS_DIVERS>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
            
            return result;
        }

        public async Task<T_FRAIS_DIVERS> GetFraisDiversById(int id)
        {
            return await base.TableNoTracking.FirstAsync(p => p.REF_CTR_FRAIS_DIVERS == id);
        }    
        
        public async Task<T_FRAIS_DIVERS> GetFraisDiversByRefCtrAndType(int id, string type)
        {
            return await base.TableNoTracking.FirstAsync(p => p.REF_CTR_FRAIS_DIVERS == id && p.TYP_FRAIS_DIVERS == type);
        }
        
        public async Task<bool> UpdateFraisDiversAsync( T_FRAIS_DIVERS updatedFraisDivers)
        {
            var existingFraisDivers = await base.Table.FirstOrDefaultAsync(p => p.REF_CTR_FRAIS_DIVERS == updatedFraisDivers.REF_CTR_FRAIS_DIVERS && p.TYP_FRAIS_DIVERS == updatedFraisDivers.TYP_FRAIS_DIVERS);

            if (existingFraisDivers == null)
            {
                throw new InvalidOperationException($"Frais divers with ref_ctr {updatedFraisDivers.REF_CTR_FRAIS_DIVERS} and type {updatedFraisDivers.TYP_FRAIS_DIVERS} not found");
            }

            // Mettez à jour les propriétés de l'entité existante avec les nouvelles valeurs
            // existingFraisDivers.Property = updatedFraisDivers.Property;

            await base.UpdateAsync(existingFraisDivers);

            return true;
        }
    }
}
