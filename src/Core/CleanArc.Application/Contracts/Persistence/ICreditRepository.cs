using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface  ICreditRepository
{
    Task AddCreditAsync(T_MVT_CREDIT mvtCredit);

}