using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Domain.StoredProcuderModel;

namespace CleanArc.Application.Contracts.Persistence;

public interface IEncaissement
{
    Task<bool> AddEncaissementAsync(T_ENCAISSEMENT encaissement);
    Task<List<T_RECOUVREMENT_DTO>> GetAllRecouvrementFactures();
    Task<List<T_RECOUVREMENT_DTO>> GetAllFacturesEchu();
    Task<List<T_RECOUVREMENT_DTO>> GetAllFacturesNonEchu();
    Task<List<SelectRefEncaissementParCtrETAch_Result>> RecherchEncAchRefCtr(int ref_ctr, int ref_ach);

    Task<List<SelectRefEncaissementParCtr>> RecherchEncCtr(int ref_ctr);
}