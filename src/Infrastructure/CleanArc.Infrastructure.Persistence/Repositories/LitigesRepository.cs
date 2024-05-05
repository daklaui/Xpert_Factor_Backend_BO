using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    public class LitigesRepository : BaseAsyncRepository<T_LITIGE>, ILitigesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LitigesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<T_LITIGE> AddLitigesAsync(T_LITIGE litige , string MONT_LT)
        {
            try
            {
                TR_TVA tva;
                try
                {
                    tva = await _dbContext.TR_TVAs.OrderByDescending(p => p.ID_TVA).FirstOrDefaultAsync();
                }
                catch (Exception e)
                {
                    tva = null;
                }

                T_LITIGE lit = await _dbContext.T_LITIGEs.Where(p => p.ID_DET_BORD_LIT == litige.ID_DET_BORD_LIT && p.ETAT_LIT == true).FirstOrDefaultAsync();
                if (lit == null)
                {
                    litige.ETAT_LIT = true;
                    litige.MONT_LT = ParseDecimalOrDefault(MONT_LT);
                    await base.AddAsync(litige);
                    await _dbContext.SaveChangesAsync();

                    TempData["notice_litige"] = "Litige enregistré avec succès";
                }
                else
                {
                    TempData["error_litige"] = "Il y a déjà un litige concernant cette facture.";
                }
            }
            catch (Exception)
            {
                TempData["error"] = "Erreur";
                return RedirectToAction("InternalServerError", "Error");
            }
            return RedirectToAction("Litiges");
        }

        private decimal ParseDecimalOrDefault(string value)
        {
            decimal result;
            if (decimal.TryParse(value, out result))
            {
                return result;
            }
            return 0; 
        }
    }
}
