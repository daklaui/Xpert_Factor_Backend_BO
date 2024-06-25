using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using CleanArc.Domain.StoredProcuderModel;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IContratRepository
    {
        Task AddContratAsync(T_CONTRAT contrat);
        Task<T_CONTRAT> GetContratById(int id);

        Task<PagedList<ListeDesContrats_Result>> GetAllContratAsync(PaginationParams paginationParams);
        Task<T_CONTRAT> GetContratByRefCtrPapier(string id);
        Task<bool> UpdateContratAsync(int id, T_CONTRAT updatedContrat);
        Task<int> GetContractsForCurrentYearasync();
        Task<List<ListeFactureValiderk>> GetAllInvoicesByContratAndBuyer(int id, int id2);
        Task AddInvoiceAsync(ListeFactureValiderk invoice);
    }
}
