using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class RibRepository : BaseAsyncRepository<TR_RIB>, IRibRepository
{
    public RibRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public Task AddRibAsync(TR_RIB contact)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<TR_RIB>> GetAllRibsByIndividuAsync(PaginationParams paginationParams)
    {
        throw new NotImplementedException();
    }

    public Task<TR_RIB> GetRibById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T_INDIVIDU>> GetAllOrdersWithRelatedUserAsync()
    {
        throw new NotImplementedException();
    }
}