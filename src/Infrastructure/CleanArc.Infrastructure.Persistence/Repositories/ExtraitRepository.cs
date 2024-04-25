using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class ExtraitRepository : BaseAsyncRepository<T_EXTRAIT>, IExtraitRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ExtraitRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task addExtraitAsync(T_EXTRAIT extrait)
    {
        await base.AddAsync(extrait);
    }

}
    





