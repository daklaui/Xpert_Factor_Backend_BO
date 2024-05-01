using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IContratRepository
    {
        Task AddContratAsync(T_CONTRAT contrat);
        //Task<PagedList<T_CONTRAT>> GetAllContratsAsync(int id , PaginationParams paginationParams);
        Task<T_CONTRAT> GetContratById(int id);

        Task<PagedList<ListeDesContrats_Result>> GetAllContratAsync(PaginationParams paginationParams);
        Task<T_CONTRAT> GetContratByRefCtrPapier(string id);
        Task<bool> UpdateContratAsync(int id, T_CONTRAT updatedContrat);
        Task<int> GetContractsForCurrentYearasync();
        //Task<ContractDetailsDTO> GetContractDTOAsync();
        
        //Task<PagedList<ContractDTO>> GetAllContratsWithDetailsAsync(PaginationParams paginationParams);

       
    }
}