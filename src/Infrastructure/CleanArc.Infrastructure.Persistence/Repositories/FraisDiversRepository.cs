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
        
        /* public async Task CreateOrUpdateFraisDiversAsync(List<T_frais_divers_web> fins, int refContract)
        {
            try
            {
                foreach (T_frais_divers_web fin in fins)
                {
                    try
                    {
                        var currentFin = await base.Table.FirstOrDefaultAsync(p => p.REF_CTR_FRAIS_DIVERS == refContract && p.TYP_FRAIS_DIVERS == fin.TYP_FRAIS_DIVERS);
                        if (currentFin != null)
                        {
                            currentFin.LIB_FRAIS_DIVERS = fin.LIB_FRAIS_DIVERS;
                            currentFin.MONT_PAR_UNIT_FRAIS_DIVERS = ParseDecimalOrDefault(fin.MONT_PAR_UNIT_FRAIS_DIVERS);
                            currentFin.REF_CTR_FRAIS_DIVERS = refContract;
                            currentFin.TYP_FRAIS_DIVERS = fin.TYP_FRAIS_DIVERS;

                            await base.UpdateAsync(currentFin);
                        }
                        else
                        {
                            T_FRAIS_DIVERS frais_divers = new T_FRAIS_DIVERS();

                            frais_divers.LIB_FRAIS_DIVERS = fin.LIB_FRAIS_DIVERS;
                            frais_divers.MONT_PAR_UNIT_FRAIS_DIVERS = ParseDecimalOrDefault(fin.MONT_PAR_UNIT_FRAIS_DIVERS);
                            frais_divers.REF_CTR_FRAIS_DIVERS = refContract;
                            frais_divers.TYP_FRAIS_DIVERS = fin.TYP_FRAIS_DIVERS;

                            await base.AddAsync(frais_divers);
                        }
                    }
                    catch (Exception e)
                    {
                        // Gérer l'erreur ici...
                        throw new Exception("Error d'enregistrement Frais divers.", e);
                    }
                }
            }
            catch (Exception e)
            {
                // Gérer l'erreur ici...
                throw new Exception("Error d'enregistrement Frais divers.", e);
            }
        }*/

        // Méthode pour convertir une chaîne en décimal
        private decimal ParseDecimalOrDefault(string value)
        {
            decimal result;
            if (decimal.TryParse(value, out result))
            {
                return result;
            }
            return 0; // Valeur par défaut si la conversion échoue
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
        
        public async Task<bool> UpdateFraisDiversAsync(int id, T_FRAIS_DIVERS updatedFraisDivers)
        {
            var existingFraisDivers = await base.Table.FirstOrDefaultAsync(e => e.REF_CTR_FRAIS_DIVERS == id);

            if (existingFraisDivers == null)
            {
                throw new InvalidOperationException($"Frais divers with id {id} not found");
            }

            // Mettez à jour les propriétés de l'entité existante avec les nouvelles valeurs
            // existingFraisDivers.Property = updatedFraisDivers.Property;

            await base.UpdateAsync(existingFraisDivers);

            return true;
        }
    }
}
