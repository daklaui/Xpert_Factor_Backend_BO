using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class LitigesRepository:BaseAsyncRepository<T_LITIGE>,ILitigesRepository
{
    private readonly ApplicationDbContext _dbContext;

    public LitigesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddLitigeAsync(T_LITIGE litige, decimal? montantLt)
    {
        try
        {
            TR_TVA tva;
            try
            {
                tva = _dbContext.TR_TVAs.OrderByDescending(p => p.ID_TVA).FirstOrDefault();
            }
            catch (Exception e)
            {
                tva = null;
            }

            T_LITIGE existingLitige = _dbContext.T_LITIGEs
                .Where(p => p.ID_DET_BORD_LIT == litige.ID_DET_BORD_LIT && p.ETAT_LIT == true)
                .FirstOrDefault();

            if (existingLitige == null)
            {
                litige.ETAT_LIT = true;
                litige.MONT_LT = montantLt ?? 0; 
                _dbContext.T_LITIGEs.Add(litige);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Il y a déjà un litige concernant cette facture.");
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Une erreur s'est produite lors de l'ajout du litige.", ex);
        }
    }
    public  List<T_LITIGE_DTO> GetAllRapportFacturesEnLitige()
    {
        return  _dbContext
            .usp_Rapport_Factures_En_Litige_VersionII
            .FromSql($"exec usp_Rapport_Factures_En_Litige_VersionII").ToList();
        
    }


    
    
}