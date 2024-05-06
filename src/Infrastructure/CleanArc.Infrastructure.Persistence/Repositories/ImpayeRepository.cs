using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class ImpayeRepository :BaseAsyncRepository<T_IMPAYE>,IimpayeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ImpayeRepository(ApplicationDbContext dbContext):base(dbContext)
    {
        _dbContext = dbContext;
    }
 
    public async Task AddImpayeAsync(T_IMPAYE impaye)
    {
        await base.AddAsync(impaye);

    }
 
    public  List<T_IMPAYE_DTO> GetListeResolutionDesImpayes()
    {
        return _dbContext.ListeDesImpayes
            .FromSql($"exec ListeDesImpayes")
            .ToList();
       
      
    }

    public  List<T_IMPAYE_DTO> GetListehistorical()
    {
        return  _dbContext.ListeDesImpayes
            .FromSql($"exec ListeDesImpayes")
            .AsEnumerable()
            .Where(imp => imp.IS_RESOLU != null && imp.IS_RESOLU == true )
            .ToList();
        
    }
    
   public List<T_IMPAYE_DTO> Listedesimpaye()
   {
    var ListImpaye = _dbContext.ListeDesImpayes
        .FromSql($"exec ListeDesImpayes")
        .AsEnumerable()
        .Where(imp => imp.IS_RESOLU == null).ToList();
    return ListImpaye;
   }


}