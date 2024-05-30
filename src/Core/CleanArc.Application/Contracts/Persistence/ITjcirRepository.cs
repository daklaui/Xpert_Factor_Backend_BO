using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ITjcirRepository
{
    
    Task AddTJCIRsync( TJ_CIR Buyer);
    Task AddBuyer(BuyerDTO buyerDto);
    Task<TJ_CIR> GetExistingActorsByRefCtr(string role, int refCtr);
    Task<bool> UpdateCirAsync(TJ_CIR updatedCir);
    Task<List<AcheteurDto>> GetAcheteursByContratAsync(int refCtrCir);
    void SaveChanges();
}