using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILitigesRepository
{
    Task AddLitigeAsync(T_LITIGE litige, decimal? montantLt);
      List<T_LITIGE_DTO> GetAllRapportFacturesEnLitige();
}