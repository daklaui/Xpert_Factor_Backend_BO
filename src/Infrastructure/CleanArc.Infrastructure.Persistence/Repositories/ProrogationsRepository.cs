using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class ProrogationsRepository : BaseAsyncRepository<T_PROROGATION>, IProrogationsRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ProrogationsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddProrogation(T_PROROGATION prorogation, DateTime echeanceFacturePro)
    {
        decimal fraisDecimal; 
        TR_TVA tva =  _dbContext.TR_TVAs.OrderByDescending(p => p.ID_TVA).FirstOrDefault();


        if (tva == null)
        {
            Console.WriteLine("TVA not found for prorogation calculation.");
            fraisDecimal = 0; 
        }
        else
        {
            fraisDecimal = (decimal)_dbContext.T_FRAIS_DIVERs
                .Where(p => p.TYP_FRAIS_DIVERS.Contains("ProL") && p.REF_CTR_FRAIS_DIVERS == prorogation.REF_CTR_PROG)
                .Select(p => p.MONT_PAR_UNIT_FRAIS_DIVERS).FirstOrDefault();
        }

        prorogation.ETAT_PROG = true;
        prorogation.TYP_PROG = "Autre";
        prorogation.DAT_PROG = echeanceFacturePro;
        _dbContext.T_PROROGATIONs.Add(prorogation);
        _dbContext.SaveChanges();

        TimeSpan ts = prorogation.ECH_PROG - echeanceFacturePro;
        short diff = (short)ts.TotalDays;
        T_DET_BORD bord = _dbContext.T_DET_BORDs.Where(p => p.ID_DET_BORD == prorogation.ID_DET_BORD_PROG.ToString()).FirstOrDefault();

        if (bord == null)
        {
            Console.WriteLine("T_DET_BORD record not found for prorogation calculation.");
            return; 
        }

        bord.ECH_APR_PROROG_DET_BORD = echeanceFacturePro;
        bord.ECH_DET_BORD += diff;
        _dbContext.Entry(bord).State = EntityState.Modified;
        _dbContext.SaveChanges();

        T_MVT_DEBIT debit = new T_MVT_DEBIT();
        debit.REF_CTR_DEBIT = prorogation.REF_CTR_PROG;
        debit.TYP_DEBIT = bord.ID_DET_BORD;
        debit.ABEV_DEBIT = "Prorogation Litige";
        debit.MONT_DEBIT = fraisDecimal * (tva?.VAL_TVA ?? 0);
        debit.DATE_DEBIT = DateTime.Now;
        _dbContext.T_MVT_DEBITs.Add(debit);
        _dbContext.SaveChanges();
    }
}