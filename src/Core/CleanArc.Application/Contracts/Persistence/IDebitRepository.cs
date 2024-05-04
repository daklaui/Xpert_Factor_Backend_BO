using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IDebitRepository
{
    Task AddDebitAsync(T_MVT_DEBIT mvtDebit);

}