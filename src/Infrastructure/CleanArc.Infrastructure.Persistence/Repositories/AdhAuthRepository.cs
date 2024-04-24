using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class AdhAuthRepository : BaseAsyncRepository<TS_USERS_WEB>, IAdhAuthRepository
{
    public AdhAuthRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public Task AddAdhAuthAsync(TS_USERS_WEB authModel)
    {
        throw new NotImplementedException();
    }

    public Task<TS_USERS_WEB> GetAuthAdhById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TS_USERS_WEB> GetAuthByIndividuAsync(int ref_ind)
    {
        throw new NotImplementedException();
    }
}