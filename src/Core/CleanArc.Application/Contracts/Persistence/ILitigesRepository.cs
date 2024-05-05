using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILitigesRepository
{
    Task<T_LITIGE>AddLitigesAsync(T_LITIGE litige, string MONT_LT);
}