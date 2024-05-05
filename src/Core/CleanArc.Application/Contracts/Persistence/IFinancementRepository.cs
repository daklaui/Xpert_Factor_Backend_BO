using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Identity.Identity.Dtos;

namespace CleanArc.Application.Contracts.Persistence;

public interface IFundingRepository
{
    Task<PagedList<T_FINANCEMENT>> GetAllFinancementAsync(PaginationParams paginationParams);
    Task<T_FINANCEMENT> AddFinanceAsync(T_FINANCEMENT finance);
    Task<T_FINANCEMENT> GetFinanceById(int id);
    Task <T_FINANCEMENT> ValidateFinanceAsync(int id ,T_FINANCEMENT finance);
    Task <T_FINANCEMENT> RejectFinanceAsync(int id ,T_FINANCEMENT finance);
    Task<T_FINANCEMENT_DTO> AllRecord(int ref_ctr);
    
}