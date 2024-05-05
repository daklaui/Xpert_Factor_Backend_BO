using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILitigesRepository
{
    Task AddLitigeAsync(T_LITIGE litige, decimal? montantLt);
}