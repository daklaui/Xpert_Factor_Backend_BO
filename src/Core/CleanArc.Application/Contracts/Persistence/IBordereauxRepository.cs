using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IBordereauxRepository
{
    Task addBordereauxAsync(T_BORDEREAU bordereau);

    Task<PagedList<GetAllBordDTO>> GetAllBordereauxAsync(PaginationParams paginationParams);
     Task<bool> UpdateBordereauxAsync(PksBordereauxDto pksDto, T_BORDEREAU updatedBordereau);
    Task<T_BORDEREAU> GetBordereauxById(string id);
    Task<T_BORDEREAU> GetBordereauxByPK(string numBord, int refCtr , string yearBord);
    Task ValidateBordereauAsync(T_BORDEREAU existingBordereau, List<T_DET_BORD> detBordList);
    Task DeleteBordereaux(T_BORDEREAU bordereau);
    Task<List<BordereauxWithIndividuDto>> GetDetailsBordByRefCtrAsync(int refCtr);


}