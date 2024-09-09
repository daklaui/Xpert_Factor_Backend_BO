

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface IRibRepository
{
    Task<bool> AddRibAsync(TR_RIB rib);
    Task<PagedList<TR_RIB>> GetAllRibsAsync( PaginationParams paginationParams);
    Task<TR_RIB> GetRibById(int id);
    Task<TR_RIB> EditRibIndividu(int id, TR_RIB rib);
    Task<TR_RIB> GetRibByRibValueAsync(string ribValue);
}