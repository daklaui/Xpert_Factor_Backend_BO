using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IDetAssRepository
    {
        Task AddDetAssAsync(T_DET_ASS detAss);
        Task<PagedList<T_DET_ASS>> GetAllDetAssAsync(PaginationParams paginationParams);
        Task<T_DET_ASS> GetDetAssById(int id);
        Task<bool> UpdateDetAssAsync(int detAssId, T_DET_ASS updatedDetAss);
        Task<T_DET_ASS> GetDetAssByRefCtrAndType(int id, string type);
    }
}