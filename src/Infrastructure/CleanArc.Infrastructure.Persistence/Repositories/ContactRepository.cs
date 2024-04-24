using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class ContactRepository : BaseAsyncRepository<T_CONTACT>, IContactRepository
{
    public ContactRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public Task AddContactAsync(T_CONTACT contact)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<T_CONTACT>> GetAllContactsByIndividuAsync(PaginationParams paginationParams)
    {
        throw new NotImplementedException();
    }

    public Task<T_CONTACT> GetContactById(int id)
    {
        throw new NotImplementedException();
    }
}