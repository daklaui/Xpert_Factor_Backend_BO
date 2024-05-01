using System;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class DemandeLimiteRepository : BaseAsyncRepository<T_DEM_LIMITE>, IDemandeLimiteRepository
    {
        public DemandeLimiteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        

        public async Task AddDemandeLimiteAsync(T_DEM_LIMITE demandeLimite)
        {
            await base.AddAsync(demandeLimite);
        }

        Task<PagedList<T_DEM_LIMITE>> IDemandeLimiteRepository.GetAllDemandesLimiteAsync(PaginationParams paginationParams)
        {
            throw new NotImplementedException();
        }

        Task<List<T_DEM_LIMITE>> IDemandeLimiteRepository.GetDemandeLimiteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T_DEM_LIMITE> GetDemandeLimiteByRefCtrAndType(int id, string type)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDemandeLimiteAsync(int demandeLimiteId, T_DEM_LIMITE updatedDemandeLimite)
        {
            throw new NotImplementedException();
        }

        

        public async Task<bool> UpdateDemandeLimiteAsync(int demandeLimiteId, T_DEM_LIMITE_DTO updatedDemandeLimite)
        {
            var existingDemandeLimite = await base.Table.FirstOrDefaultAsync(p => p.REF_DEM_LIM == updatedDemandeLimite.REF_DEM_LIM);

            if (existingDemandeLimite == null)
            {
                throw new InvalidOperationException($"Demande limite with REF_DEM_LIM {updatedDemandeLimite.REF_DEM_LIM} not found");
            }

            await base.UpdateAsync(existingDemandeLimite);

            return true;
        }
    }
}