

using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IIndividualRepository
{
    Task AddIndividualDTOAsync(IndividualDTO individualDTO);
    Task<PageInfo<IndividualDTO>> GetAllIndividualDTOsAsync(PaginationParams paginationParams);
    Task<IndividualDTO> GetIndividuByIdAsync(int id);
    Task<bool> UpdateIndividuAsync(int id, IndividualDTO updatedIndividualDTO);
    Task<List<AdherentDto>> GetAllAdherentsAsync();
    Task<List<int>> GetRefCtrCirByRefIndAsync(int refInd);
    Task<List<NomIndividuDto>> GetAllNomIndivAsync();

    Task<List<AdherentDetailDto>> GetAdherentDetailsByAdherentAsync(int refIndiv);
    Task<List<NomIndividuDto>> GetAcheteurSansContrat(int refctr);
    Task<List<NomIndividuDto>> GetAcheteurPourContrat(int refctr);

}