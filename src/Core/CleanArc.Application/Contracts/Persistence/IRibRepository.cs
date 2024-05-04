

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface IRibRepository
{
    Task<bool> AddRibAsync(TR_RIB rib);
    Task<PagedList<TR_RIB>> GetAllRibsByIndividuAsync(int refIndRib, PaginationParams paginationParams);
    Task<TR_RIB> GetRibById(string id);
    Task<TR_RIB_DTO> EditRibIndividu(TR_RIB_DTO rib);
}