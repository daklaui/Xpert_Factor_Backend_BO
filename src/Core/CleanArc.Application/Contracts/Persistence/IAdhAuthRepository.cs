

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IAdhAuthRepository
{
    Task AddAdhAuthAsync(TS_USERS_WEB authModel);
    Task<TS_USERS_WEB> GetAuthByIndividuAsync(int ref_ind);
    Task<TS_USERS_WEB> GetAuthAdhById(int id);
    //Task<List<Individu>> GetAllOrdersWithRelatedUserAsync();
}