using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILimiteRepository
{
    Task<T_DEM_LIMITE> AddTDemLimitesync(T_DEM_LIMITE demLimite);


    Task<DemLimListingDTO> checkExistingLimiteNoActif(int refCtr, int refInd);


     Task<List< T_DEM_LIMITE_DTO>> getListOfDemLimitNoActif();
    


    Task<List<T_DEM_LIMITE_DTO>> getAllLDemLimites();
    

    Task<bool> validateLimite(int id);
    
}