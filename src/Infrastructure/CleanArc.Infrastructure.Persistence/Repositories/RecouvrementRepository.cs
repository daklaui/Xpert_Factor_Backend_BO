using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Identity;
using CleanArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

internal class RecouvrementRepository : BaseAsyncRepository<RecouvrementDto>, IRecouvrementRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RecouvrementRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext =dbContext;
    }
    public async Task<List<RecouvrementDto>> GetAllRecouvrementAsync(PaginationParams paginationParams)
    {
        var result = await _dbContext.Set<RecouvrementDto>()
            .FromSqlRaw("EXEC Recouvrement_All_Factures")
            .ToListAsync();

        return result;
    }
   
}