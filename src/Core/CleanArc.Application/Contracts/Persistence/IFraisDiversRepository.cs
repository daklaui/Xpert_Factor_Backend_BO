using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IFraisDiversRepository
    {
        Task AddFraisDiversAsync(T_FRAIS_DIVER fraisDivers);
        Task<PagedList<T_FRAIS_DIVER>> GetAllFraisDiversAsync(PaginationParams paginationParams);
        Task<List<T_FRAIS_DIVER>> GetFraisDiversById(int id);
        Task<T_FRAIS_DIVER> GetFraisDiversByRefCtrAndType(int id, string type);
        Task<bool> UpdateFraisDiversAsync(int fraisDiversId, T_FRAIS_DIVER updatedFraisDivers);
    }
}
