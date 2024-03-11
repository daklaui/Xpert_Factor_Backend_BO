using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IAgencyBankRepository
{     Task<TR_Ag_Bq> AddTrAgencyBankAsync(TR_Ag_Bq trAgBq);
    Task<PagedList<TR_Ag_Bq>> GetAllTrAgencyBankAsync(PaginationParams paginationParams);
    Task<TR_Ag_Bq> GetTrAgencyBankById(string code);
    
    Task UpdateTrAgencyBankAsync(TR_Ag_Bq bankAgency);    

    
}