using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
namespace CleanArc.Application.Contracts.Persistence;

public interface ICreditRepository
{
    public Task AddCreditAsync(T_MVT_CREDIT credit);

}