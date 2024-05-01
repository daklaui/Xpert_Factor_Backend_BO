using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IFraisPaiementRepository
    {
        Task AddFraisPaiementAsync(T_FRAIS_PAIEMENT fraisPaiement);
        Task<PagedList<T_FRAIS_PAIEMENT>> GetAllFraisPaiementAsync(PaginationParams paginationParams);
        Task<List<T_FRAIS_PAIEMENT>> GetFraisPaiementById(int id);
        Task<T_FRAIS_PAIEMENT> GetFraisPaiementByRefCtrAndType(int id, string type);
        Task<bool> UpdateFraisPaiementAsync(int fraisPaiementId, T_FRAIS_PAIEMENT updatedFraisPaiement);
    }
}