using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IDebitRepository
{
    public Task addDebitAsync(T_MVT_DEBIT Debit);
}