using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface IimpayeRepository
{
    Task AddImpayeAsync(T_IMPAYE impaye);
     List<T_IMPAYE_DTO> Listedesimpaye();
    List<T_IMPAYE_DTO> GetListehistorical();
   List<T_IMPAYE_DTO> GetListeResolutionDesImpayes();
   
}