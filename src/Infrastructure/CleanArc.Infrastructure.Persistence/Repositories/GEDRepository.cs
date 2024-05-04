using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

internal class GEDRepository: BaseAsyncRepository<T_DOC_GED>, IGEDRepository
{
    private readonly ApplicationDbContext _dbContext;

    public GEDRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<GEDNumerisationDTO>> GetAllGEDNumerisationAsync(PaginationParams paginationParams)
    {
        var result = await _dbContext.Set<GEDNumerisationDTO>()
            .FromSqlRaw("EXEC T_DOC_GED_SCAN")
            .ToListAsync();

        return result;
    }
    public async Task<List<GEDValidationDTO>> GetAllGEDValidationAsync(PaginationParams paginationParams)
    {
        var result = await _dbContext.Set<GEDValidationDTO>()
            .FromSqlRaw("exec T_DOC_GED_VALID")
            .ToListAsync();

        return result;
    }
}