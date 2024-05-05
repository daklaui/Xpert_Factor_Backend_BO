using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ICpRepository
{
        Task <TR_CP> AddCpAsync(TR_CP cp);
        Task UpdateCpAsync(TR_CP cp);
        Task<PagedList<TR_CP>> GetPostsList (PaginationParams paginationParams);
       

}