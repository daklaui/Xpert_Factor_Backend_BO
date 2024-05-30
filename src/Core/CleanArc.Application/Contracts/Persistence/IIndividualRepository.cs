

using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IIndividualRepository
{
    Task AddIndividualDTOAsync(IndividualDTO individualDTO);
    Task<PageInfo<IndividualDTO>> GetAllIndividualDTOsAsync(PaginationParams paginationParams);
    Task<IndividualDTO> GetIndividuByIdAsync(int id);
    Task<bool> UpdateIndividuAsync(int id, T_INDIVIDU updatedIndividu);
    Task<List<AdherentDto>> GetAllAdherentsAsync();
    Task<List<int>> GetRefCtrCirByRefIndAsync(int refInd);
    Task<PagedList<NomIndividuDto>> GetAllNomIndivAsync(PaginationParams paginationParams);

    Task<List<AdherentDetailDto>> GetAdherentDetailsByAdherentAsync(int refIndiv);
    Task<List<NomIndividuDto>> GetIndividusSansContrat(int refctr);
}