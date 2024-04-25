using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Identity.Identity.Dtos;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
namespace CleanArc.Infrastructure.Persistence.Repositories;

public class FinancementRepository :BaseAsyncRepository<T_FINANCEMENT>,IFinancementRepository
{
    private readonly ApplicationDbContext _dbContext;

    public FinancementRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    string buildProcedureName(int REF_CTR) => "exec All_Ecran_Financements " + "@Ref_Ctr = '" + REF_CTR + "'";


    public  async Task<PagedList<T_FINANCEMENT>> GetAllFinancementAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<T_FINANCEMENT>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

        return result;
    }
   /* public async Task<All_Ecran_Financements> GetAllEcranFinancements(int refCtr)
    {
        try
        {
            return  _dbContext.All_Ecran_Financements
                .FromSqlRaw(buildProcedureName(refCtr))
                .AsEnumerable()
                .FirstOrDefault();
        }
        catch (Exception ex)
        {
            throw new Exception("Error retrieving AllEcranFinancements data", ex);
        }
    }*/
  /*  public async Task<SumOfMnt> GetSumOfMnt(int refCtr)
    {
        try
        {
            return  _dbContext.SumOfMnts
                .FromSqlRaw($"exec SumOfMnt @RefCtr={refCtr}")
                .AsEnumerable()
                .FirstOrDefault();
        }
        catch (Exception ex)
        {
            throw new Exception("Error retrieving SumOfMnt data", ex);
        }
    }
    public async Task<decimal> GetFraisDivers(string procedureName, int paramPortRefCtr)
    {
        try
        {
            return (decimal) _dbContext.Database
                .SqlQuery<decimal>($"exec {procedureName} @param_Port_Ref_CTR = {paramPortRefCtr}")
                .AsEnumerable()
                .FirstOrDefault();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error retrieving data from procedure '{procedureName}'", ex);
        }
    }*/


    //add
    public async Task<T_FINANCEMENT> AddFinanceAsync(T_FINANCEMENT finance)
    {
        finance.ID_FIN = 0;
        if (finance == null)
        {
            throw new ArgumentNullException(nameof(finance), "Cannot add a null entity");
        }

        await base.AddAsync(finance);
   
        return finance;    
    }
    //get
    public async Task<T_FINANCEMENT> GetFinanceById(int id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_FIN == id);

    }
    //validate
    public async Task<T_FINANCEMENT> ValidateFinanceAsync(int id, T_FINANCEMENT finance)   
    {
        var tFinance = await _dbContext.Set<T_FINANCEMENT>().FirstOrDefaultAsync(e => e.ID_FIN == id);
        
        if (tFinance == null)
        {
            
            throw new InvalidOperationException($"Financement with id {id} not found");
        }

        tFinance.ETAT_FIN = "valider";
        await _dbContext.SaveChangesAsync();
        return tFinance;
    }
    //reject

    public async Task<T_FINANCEMENT> RejectFinanceAsync(int id, T_FINANCEMENT finance)
    {
        var tFinance = await _dbContext.Set<T_FINANCEMENT>().FirstOrDefaultAsync(e => e.ID_FIN == id);
        
        if (tFinance == null)
        {
            
            throw new InvalidOperationException($"Financement with id {id} not found");
        }

        tFinance.ETAT_FIN = "rejeter";
        await _dbContext.SaveChangesAsync();
        return tFinance;
    }
 //AllRecord
    public async Task<FinancementDto> AllRecord(int ref_ctr)
    {

        DateTime currentDate = DateTime.Today;
        int currentYear = currentDate.Year;
        int currentMonth = currentDate.Month;


        decimal GetSumFromDatabase(FormattableString query)
        {

            decimal result = _dbContext.Database.SqlQuery<decimal>(query).AsEnumerable().FirstOrDefault();
            return result != default(decimal) ? result : 0;
        }

        
        var all = new All_Ecran_Financements();
        var sumOfMnt = _dbContext.SumOfMnts.FromSqlRaw($"exec SumOfMnt @RefCtr={ref_ctr}").AsEnumerable()
            .FirstOrDefault();

        try
        {
            all = _dbContext.All_Ecran_Financements.FromSqlRaw(buildProcedureName((ref_ctr))).AsEnumerable().First();
        }
        catch (Exception e)
        {
            all = null;
        }


        decimal sumMntImpaye = sumOfMnt.SumMntImpaye ?? 0;
        decimal sumMntLitige = sumOfMnt.SumMntLitige ?? 0;
        decimal sumMntFactDepAlgo = sumOfMnt.SumMntFactDepAlgo ?? 0;

        decimal disponible_SansFdg = sumOfMnt.Disponible_Sans_FDG_Libérer ?? 0;
        decimal fdg_liberer_from_fin = sumOfMnt.FDG_Libérer_From_T_Finacement ?? 0;
        decimal fdg_librer_calc = sumOfMnt.Financemnt_Sans_FDG_Libérer ?? 0;
        decimal fdg_librer_sum = sumOfMnt.Sum_FDG_Libérer ?? 0;


        decimal t_fraisdiversC = 0;
        decimal t_fraisdivers = 0;
        decimal t_fraisdiversT = 0;
        decimal t_fraisdiversV = 0;
        decimal montFinEncours = 0;

        var disponible = all?.Disponible ?? 0;

        try
        {
            t_fraisdivers = (decimal)_dbContext.usp_FRAIS_DIVERS
                .FromSql($"exec usp_FRAIS_DIVERS @param_Port_Ref_CTR = {ref_ctr}").AsEnumerable()
                .Select(p => p.FraisDiv).FirstOrDefault();
        }
        catch (Exception)
        {
            t_fraisdivers = 0;
        }

        try
        {
            t_fraisdiversC = (decimal)_dbContext.usp_FRAIS_PAIEMENT_C
                .FromSql($"exec usp_FRAIS_PAIEMENT_C @param_Port_Ref_CTR = {ref_ctr}").AsEnumerable().FirstOrDefault()
                .FraisPaiC;
        }
        catch (Exception)
        {
            t_fraisdiversC = 0;
        }

        try
        {
            t_fraisdiversT = (decimal)_dbContext.usp_FRAIS_PAIEMENT_T
                .FromSql($"exec usp_FRAIS_PAIEMENT_T @param_Port_Ref_CTR = {ref_ctr}").AsEnumerable().FirstOrDefault()
                .FraisPaiT;
        }
        catch (Exception)
        {
            t_fraisdiversT = 0;
        }

        try
        {
            t_fraisdiversV = (decimal)_dbContext.usp_FRAIS_PAIEMENT_V
                .FromSql($"exec usp_FRAIS_PAIEMENT_V @param_Port_Ref_CTR = {ref_ctr}").AsEnumerable().FirstOrDefault()
                .FaisPaiV;
        }
        catch (Exception)
        {
            t_fraisdiversV = 0;
        }

        //var depassLimResults = _db.usp_Etat_Depass_Lim_ACH.FromSql($"exec usp_Etat_Depass_Lim_ACH @param_Port_Ref_CTR = {ref_ctr}").AsEnumerable();
        FinancementDto financementDto = new FinancementDto
        {
            Total_Dispo = disponible,
            Encours_Factures = all?.Encours_Facture ?? 0,
            Depass_Lim_Ach = all?.Depass_Limite ?? 0,
            Fonds_Reserve = all?.Toatl_FDG ?? 0,
            Interet_Cumule_Mois_EnCours = GetSumFromDatabase(
                $"SELECT ISNULL(SUM(INTERET_J_CALC_DISPO), 0) FROM t_calc_dispo WHERE REF_CTR_CALC_DISPO = {ref_ctr} AND DAY(DATE__CALC_DISPO) < DAY(GETDATE()) AND MONTH(DATE__CALC_DISPO) = {currentMonth} AND YEAR(DATE__CALC_DISPO) = {currentYear}"),

            Interet_Cumule_Annee_EnCours = GetSumFromDatabase(
                $"SELECT ISNULL(SUM(INTERET_J_CALC_DISPO), 0) FROM t_calc_dispo WHERE REF_CTR_CALC_DISPO = {ref_ctr} AND MONTH(DATE__CALC_DISPO) < {currentMonth} AND YEAR(DATE__CALC_DISPO) = {currentYear}"),

            Interet_Retard_Mois_EnCours = GetSumFromDatabase(
                $"SELECT ISNULL(SUM(mont_calc_ir), 0) FROM T_CALC_INT_IR WHERE REF_CTR_CALC_IR = {ref_ctr} AND DAY(Date_Echeance_IR) < DAY(GETDATE()) AND MONTH(Date_Echeance_IR) = {currentMonth} AND YEAR(Date_Echeance_IR) = {currentYear}"),

            Interet_Retard_Annee_EnCours = GetSumFromDatabase(
                $"SELECT ISNULL(SUM(mont_calc_ir), 0) FROM T_CALC_INT_IR WHERE REF_CTR_CALC_IR = {ref_ctr} AND MONTH(Date_Echeance_IR) < {currentMonth} AND YEAR(Date_Echeance_IR) = {currentYear}"),
            Instruments_Paiement_Impayes = 0, // TODO: Add your logic here
            Retard_Paiement_Algorithme = sumMntFactDepAlgo,
            Litiges_Overts_Depassement = sumMntLitige,
            Total_Dispo2 = disponible - sumMntImpaye - sumMntLitige - sumMntFactDepAlgo,
            Total_Facture = all?.Total_Facture ?? 0,
            Total_Financement = all?.Total_Financement ?? 0,
            Total_Avoir = all?.Total_Avoir ?? 0,
            Total_Com_factoring = all?.Total_Commission ?? 0,
            Total_Frais_Divers = t_fraisdivers,
            Total_Frais = t_fraisdiversT + t_fraisdiversV + t_fraisdiversC,
            Total_Credit = all?.Total_Credit ?? 0,
            Total_Debit = all?.Total_Debit ?? 0,
            Total_Financement_Rapport_Enc = montFinEncours,
            Total_Interet_TTC = all?.Total_Interet ?? 0,
            Total_Interet_Retard_TTC = all?.Total_IR_All_annee ?? 0,
            //Financement_Mois = (decimal)listeachatsfina.Sum(x => x.montant_financement),
            Total_Retenu = all?.Total_Retenue ?? 0
        };

        return financementDto;
    }
}

