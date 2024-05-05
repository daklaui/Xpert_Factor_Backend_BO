using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IListValRepository
{
    Task<List<TR_LIST_VAL>> GetAllRecouvrementAsync();

}