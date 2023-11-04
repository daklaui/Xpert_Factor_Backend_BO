using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class IndividuRepository : BaseAsyncRepository<TIndividu>, IIndividualRepository
{
    public IndividuRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddIIndividualAsync(TIndividu individu)
    {
        await base.AddAsync(individu);
    }

    public  async Task<List<TIndividu>> GetAllIndividusAsync()
    {
      return  await  base.TableNoTracking.ToListAsync();
    }

    public async Task<TIndividu> GetIndividuById(int id)
    {
          return await base.TableNoTracking.FirstAsync(p=>p.Id == id);
    }
}