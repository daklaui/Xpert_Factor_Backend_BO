using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITJobsRepository
    {
        Task AddTJobsAsync(TR_ACTPROF_BCT actprofBct);
        Task<List<TR_ACTPROF_BCT>> GetAllTJobsAsync();
        Task<TR_ACTPROF_BCT> GetTJobsById(string id);
        Task<bool> UpdateTJobsAsync(string id, TR_ACTPROF_BCT updatedTJobs);

    }
}
