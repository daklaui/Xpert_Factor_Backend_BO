using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface IEncaissement
{
    Task<bool> AddEncaissementAsync(T_ENCAISSEMENT encaissement);
    Task<List<T_RECOUVREMENT_DTO>> GetAllRecouvrementFactures();
    Task<List<T_RECOUVREMENT_DTO>> GetAllFacturesEchu();
    Task<List<T_RECOUVREMENT_DTO>> GetAllFacturesNonEchu();


}