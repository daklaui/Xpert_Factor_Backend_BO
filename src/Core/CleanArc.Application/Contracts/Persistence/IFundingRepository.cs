using CleanArc.Infrastructure.Identity.Identity.Dtos;
namespace CleanArc.Application.Contracts.Persistence;

public interface IFundingRepository
{
    Task<FinancementDto> AllRecord(int ref_ctr);

}