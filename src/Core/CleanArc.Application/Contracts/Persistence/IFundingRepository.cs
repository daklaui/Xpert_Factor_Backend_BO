using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IFinancementRepository
{
    Task<T_FINANCEMENT> GetFinancementById(int REF_CTR);

    Task AddFinancementAsync(T_FINANCEMENT financement);
}