using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IDemandeLimiteRepository
    {
        Task AddDemandeLimiteAsync(T_DEM_LIMITE demandeLimite);
        Task<PagedList<T_DEM_LIMITE>> GetAllDemandesLimiteAsync(PaginationParams paginationParams);
        Task<List<T_DEM_LIMITE>> GetDemandeLimiteById(int id);
        Task<T_DEM_LIMITE> GetDemandeLimiteByRefCtrAndType(int id, string type);
        Task<bool> UpdateDemandeLimiteAsync(int demandeLimiteId, T_DEM_LIMITE updatedDemandeLimite);
    }
}