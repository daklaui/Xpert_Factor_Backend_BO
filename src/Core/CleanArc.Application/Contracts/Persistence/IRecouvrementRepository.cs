using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IRecouvrementRepository
{
    Task<PagedList<TR_LIST_VAL>> GetAllRecAsync(PaginationParams paginationParams);

    Task AddRecouvrementAsync(TR_LIST_VAL Recouvrement);
    Task<TR_LIST_VAL> GetRecouvrementById(int id);
    Task<bool> UpdateDocumentDetBordAsync(int id, TR_LIST_VAL updatedRecouvrement);
}