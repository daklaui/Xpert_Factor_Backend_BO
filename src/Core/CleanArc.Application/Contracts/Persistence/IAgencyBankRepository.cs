using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IAgencyBankRepository
{     Task<TR_Ag_Bq> AddTrAgencyBankAsync(TR_Ag_Bq trAgBq);
    Task<PagedList<TR_Ag_Bq>> GetAllTrAgencyBankAsync(PaginationParams paginationParams);
    Task<TR_Ag_Bq> GetTrAgencyBankById(string code);
    Task<string> SearchBank(string codeBank);
    Task<string> ResearchAgency(string codeAgency);
    Task<bool> UpdateTrAgencyBankAsync(String code, TR_Ag_Bq updateAgBq);


}