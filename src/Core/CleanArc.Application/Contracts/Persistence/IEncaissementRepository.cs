using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IEncaissement
{
    Task<bool> AddEncaissementAsync(T_ENCAISSEMENT encaissement);

}