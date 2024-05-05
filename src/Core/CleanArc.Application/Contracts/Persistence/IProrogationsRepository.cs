using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IProrogationsRepository
{
    Task<T_PROROGATION>AddProrogationsAsync(T_PROROGATION prorogation);
}