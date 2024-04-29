using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IBordereauxRepository
{
    Task addBordereauxAsync(T_BORDEREAU bordereau);
    
    Task<PagedList<T_BORDEREAU>> GetAllBordereauxAsync(PaginationParams paginationParams);
     Task<bool> UpdateBordereauxAsync(PksBordereauxDto pksDto, T_BORDEREAU updatedBordereau);
    Task<T_BORDEREAU> GetBordereauxById(string id);
    Task<T_BORDEREAU> GetBordereauxByPK(string numBord, int refCtr , string yearBord);
    Task<bool> ValidateBordereauAsync(string numBord, int refCtr, string yearBord);
    Task DeleteBordereaux(T_BORDEREAU bordereau);

}