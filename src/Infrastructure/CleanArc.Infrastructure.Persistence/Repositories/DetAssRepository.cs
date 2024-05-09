using System;
using System.Linq;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class DetAssRepository : BaseAsyncRepository<T_DET_ASS>, IDetAssRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public DetAssRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddDetAssAsync(T_DET_ASS detAss)
        {
            await base.AddAsync(detAss);
        }

        public async Task<PagedList<T_DET_ASS>> GetAllDetAssAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<T_DET_ASS>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
            
            return result;
        }

        public async Task<T_DET_ASS> GetDetAssById(int id)
        {
            return await base.TableNoTracking.FirstAsync(p => p.REF_ASS == id);
        }    
        
        public async Task<bool> UpdateDetAssAsync(int detAssId, T_DET_ASS updatedDetAss)
        {
            var existingDetAss = await base.Table.FirstOrDefaultAsync(p => p.REF_ASS == updatedDetAss.REF_ASS);

            if (existingDetAss == null)
            {
                throw new InvalidOperationException($"Det Ass with ref_ass {updatedDetAss.REF_ASS} not found");
            }

            existingDetAss.PRIME_ASS = updatedDetAss.PRIME_ASS;
            existingDetAss.TX_COUVERTURE_ASS = updatedDetAss.TX_COUVERTURE_ASS;
            existingDetAss.DELAIS_DECALARATION_SINISTRE_ASS = updatedDetAss.DELAIS_DECALARATION_SINISTRE_ASS;
            existingDetAss.ACTIF_ASS = updatedDetAss.ACTIF_ASS;

            await base.UpdateAsync(existingDetAss);

            return true;
        }
        
        public async Task<T_DET_ASS> GetDetAssByRefCtrAndType(int id, string type)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.REF_CTR_ASS == id );
        }

    }
}

