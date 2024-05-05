using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class ProrogationsRepository : BaseAsyncRepository<T_PROROGATION>, IProrogationsRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ProrogationsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }

    public async Task<T_PROROGATION> AddProrogationsAsync(T_PROROGATION prorogation)
    {
        if (prorogation == null)
        {
            throw new ArgumentNullException(nameof(prorogation), message: "Can not add a null entity");
        }

        await base.AddAsync(prorogation);
        return prorogation;
    }
}