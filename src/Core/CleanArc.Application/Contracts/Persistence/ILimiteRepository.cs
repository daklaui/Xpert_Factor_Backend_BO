using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILimiteRepository
{
    Task<T_DEM_LIMITE> AddTDemLimitesync(T_DEM_LIMITE demLimite);
}