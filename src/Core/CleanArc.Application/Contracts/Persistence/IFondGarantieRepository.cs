using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IFondGarantieRepository
    {
        Task AddFondGarantieAsync(T_FOND_GARANTIE fondGarantie);
        Task<PagedList<T_FOND_GARANTIE>> GetAllFondsGarantieAsync(PaginationParams paginationParams);
        Task<List<T_FOND_GARANTIE>> GetFondGarantieById(int id);
        Task<T_FOND_GARANTIE> GetFondGarantieByRefCtrAndType(int id, string type);
        Task<bool> UpdateFondGarantieAsync(int fondGarantieId, T_FOND_GARANTIE updatedFondGarantie);
    }
}