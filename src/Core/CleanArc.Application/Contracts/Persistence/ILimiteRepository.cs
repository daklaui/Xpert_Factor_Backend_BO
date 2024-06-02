using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILimiteRepository
{
    Task<T_DEM_LIMITE> AddTDemLimitesync(T_DEM_LIMITE demLimite);
    Task<T_DEM_LIMITE_DTO> checkExistingLimiteNoActif(int refCtr, int refInd);
    Task<PagedList<T_DEM_LIMITE_DTO>> getListOfDemLimitNoActif(PaginationParams paginationParam);
    Task<PagedList<T_DEM_LIMITE>> getAllLDemLimites(PaginationParams paginationParams);
    Task<T_DEM_LIMITE> validateLimite(int id);
    Task<T_DEM_LIMITE> GetDemLimiteById(int id);
    Task<bool> UpdateDemandeLimiteAsync(int demandeLimiteId, T_DEM_LIMITE updatedDemandeLimite);
    Task<T_DEM_LIMITE> GetDemandeLimiteByRefCtrAndType(int id, string type);
    Task AddBuyerLimit(BuyerDTO buyerDto);
    Task<PagedList<T_DEM_LIMITE>> GetAllListOfDemLimitNoActif(PaginationParams paginationParam);

}