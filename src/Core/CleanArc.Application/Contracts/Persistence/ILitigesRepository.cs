using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILitigesRepository
{
    Task AddLitigeAsync(T_LITIGE litige, decimal? montantLt);
      List<T_LITIGE_DTO> GetAllRapportFacturesEnLitige();
      Task AddLitige(T_LITIGE litige);
      Task<PagedList<T_LITIGE>> GetAllLitigesAsync(PaginationParams paginationParams);

}