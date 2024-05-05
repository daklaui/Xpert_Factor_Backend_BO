using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class EncaissementReposiotry:BaseAsyncRepository<T_ENCAISSEMENT>, IEncaissement
{
    private readonly ApplicationDbContext _dbContext;
    public EncaissementReposiotry(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;

    }
    public Task<bool> CheckExistingRefEnc(int id, string id2)
    {
        var encExists = _dbContext.T_MVT_CREDITs.Any(p => p.REF_CTR_CREDIT == id && p.REF_ENC_CREDIT == id2);
        return Task.FromResult(encExists);
    }
    
    public async Task<bool> AddEncaissementAsync(T_ENCAISSEMENT encaissement)
    {
        if (encaissement.DAT_VAL_ENC.Value.Date >= DateTime.Now.Date)
        {
            List<T_ENCAISSEMENT> enclist = new List<T_ENCAISSEMENT>();
            try
            {
                enclist = _dbContext.T_ENCAISSEMENTs
                    .Where(p => p.REF_ACH_ENC == encaissement.REF_ACH_ENC && p.REF_ENC == encaissement.REF_ENC &&
                                p.VALIDE_ENC == true)
                    .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (enclist.Count == 0)
            {
                try
                {
                    if (encaissement.TYP_ENC == "Ret")
                    {
                        encaissement.TYP_ENC = "A";
                        encaissement.REF_ENC = "Ret" + encaissement.REF_ENC;
                    }

                    encaissement.MONT_ENC =
                        decimal.Parse(encaissement.MONT_ENC.ToString().Replace(" ", "").Replace(",", "."));
                    encaissement.VALIDE_ENC = true;
                    encaissement.REF_CTR_ENC = _dbContext.T_CONTRATs
                        .Where(p => p.REF_CTR_PAPIER_CTR == encaissement.REF_CTR_ENC.ToString()).FirstOrDefault()
                        .REF_CTR;
                    _dbContext.T_ENCAISSEMENTs.Add(encaissement);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        await base.AddAsync(encaissement);

        return false;
    }
    public async Task<List<T_RECOUVREMENT_DTO>> GetAllRecouvrementFactures()
    {
        var ListeFacture =  _dbContext.Recouvrement_All_Factures.FromSql($"exec Recouvrement_All_Factures").ToList();
        return ListeFacture;
    } 
    public  async  Task<List<T_RECOUVREMENT_DTO>>GetAllFacturesEchu()
    {
        var ListeFactureEch = _dbContext.FacturesEchu.FromSql($"exec FacturesEchu").ToList();
        return ListeFactureEch;
    }
    public  async  Task<List<T_RECOUVREMENT_DTO>>GetAllFacturesNonEchu()
    {
        var listefactureNonEchu = _dbContext.FacturesNonEchu.FromSql($"exec FacturesNonEchu").ToList();

        return listefactureNonEchu;
    }
    
    

}