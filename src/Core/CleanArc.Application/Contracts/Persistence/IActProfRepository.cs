using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IActProfRepository
{
    Task <TR_ACTPROF_BCT> AddActprofAsync(TR_ACTPROF_BCT actprofBct);
    Task UpdateActprofAsync(TR_ACTPROF_BCT actprofBct);
    Task<PagedList<TR_ACTPROF_BCT>> GetJobsList(string paginationParams);

}