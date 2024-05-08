using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class ContactRepository : BaseAsyncRepository<T_CONTACT>, IContactRepository
{
    private ApplicationDbContext _dbContext;

    public ContactRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddContactAsync(T_CONTACT contact)
    {
        await base.AddAsync(contact);
    }

    public async Task<PagedList<T_CONTACT>> GetAllContactsAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<T_CONTACT>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task<T_CONTACT> GetContactById(int id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.ID_CONTACT == id);
    }

    public  async Task<bool> UpdateContactAsync(int id, T_CONTACT updatedContact)
    {
        var existingContact = await base.Table.FirstOrDefaultAsync(e => e.ID_CONTACT == id);

        if (existingContact == null)
        {
            throw new InvalidOperationException($"updatedContact with id {id} not found");
        }
        existingContact.MAIL1_COONTACT = updatedContact.MAIL1_COONTACT;
        existingContact.MAIL2_COONTACT = updatedContact.MAIL2_COONTACT;
        existingContact.FAX_CONTACT = updatedContact.FAX_CONTACT;
        existingContact.ACTIF_CONTACT = updatedContact.ACTIF_CONTACT;
        existingContact.TEL1_CONTACT = updatedContact.TEL2_CONTACT;
        existingContact.POS_CONTACT = updatedContact.POS_CONTACT;
        existingContact.NOM_PRE_CONTACT = updatedContact.NOM_PRE_CONTACT;
        existingContact.REF_IND_CONTACT = updatedContact.REF_IND_CONTACT;
        
        await base.UpdateAsync(existingContact);
        return true;
    }
}