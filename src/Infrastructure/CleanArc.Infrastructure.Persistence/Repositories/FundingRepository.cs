using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Identity.Identity.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class FinancementRepository : IFinancementRepository
{

    private readonly ApplicationDbContext _db;

    public FinancementRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    private string buildProcedureName(int ref_ctr)
    {
        return $"NomDeLaProcedureStockee_{ref_ctr}";
    }
public  async Task<FinancementDto>  AllRecord(int ref_ctr)
{
    decimal disponible = 0;
    decimal a = 0;
    decimal b = 0;
    decimal c = 0;
     SumOfMnt sumOfMnt = _db.SumOfMnts.FromSqlRaw($"exec SumOfMnt @RefCtr={ref_ctr}").AsEnumerable().First();
    try { a = (decimal)sumOfMnt.SumMntImpaye; } catch (Exception) { a = 0; }
    try { b = (decimal)sumOfMnt.SumMntLitige; } catch (Exception) { b = 0; }
    try { c = (decimal)sumOfMnt.SumMntFactDepAlgo; } catch (Exception) { c = 0; }

    var all = _db.All_Ecran_Financements.FromSqlRaw(buildProcedureName((ref_ctr))).AsEnumerable().First();
    decimal totalfact = 0;
    decimal Avoir = 0; 
    decimal comfact = 0; 
    decimal t_fraisdiversC = 0;
    decimal t_fraisdivers = 0; 
    decimal t_fraisdiversT = 0; 
    decimal t_fraisdiversV = 0; 
    decimal t_credit = 0; 
    decimal t_debit = 0;
    decimal FDG = 0; 
    decimal dep_limite = 0;
    decimal FDR = 0;
    decimal total_intert = 0; 
    decimal total_retenu = 0;
    decimal interet_par_an = 0; 
    decimal interet_retard_par_an = 0; 
    decimal total_intert_de_retard = 0; 
    decimal montFinEncours = 0;
    decimal total_ctr_fin = 0;
    decimal Total_Dipo = totalfact - total_ctr_fin - Avoir - comfact - t_fraisdiversC - t_fraisdivers - t_fraisdiversT - t_fraisdiversV + t_credit - t_debit - FDG - dep_limite - FDR - total_intert - total_retenu - interet_par_an - interet_retard_par_an - total_intert_de_retard;

    FinancementDto financementDto = new FinancementDto
    {
        Total_Dipo = Total_Dipo,
        Encours_Factures = (decimal)all.Encours_Facture,
        Depass_Lim_Ach = (decimal)_db.usp_Etat_Depass_Lim_ACH.FromSql($"exec usp_Etat_Depass_Lim_ACH @param_Port_Ref_CTR = {ref_ctr}").AsEnumerable().Sum(p => p.DepassLim),
        Fonds_Reserve = (decimal)all.Toatl_FDG,
        Interet_Cumule_Mois_EnCours = _db.Database.SqlQuery<decimal>($"select ISNULL(SUM(INTERET_J_CALC_DISPO), 0) from t_calc_dispo where REF_CTR_CALC_DISPO = {ref_ctr} and(day(DATE_CALC_DISPO) < day(getdate())) and(month(DATECALC_DISPO) = month(getdate()) and(year(DATE_CALC_DISPO)) = year(getdate()))").AsEnumerable().First(),
        Interet_Cumule_Annee_EnCours = _db.Database.SqlQuery<decimal>($"select ISNULL(SUM(INTERET_J_CALC_DISPO), 0) from t_calc_dispo where REF_CTR_CALC_DISPO = {ref_ctr} and (month(DATE_CALC_DISPO)<month(getdate()) and (year(DATE_CALC_DISPO))=year(getdate()))").AsEnumerable().First(),
        Interet_Retard_Mois_EnCours = _db.Database.SqlQuery<decimal>($"select ISNULL(SUM(mont_calc_ir),0)  from T_CALC_INT_IR where REF_CTR_CALC_IR= {ref_ctr} and (day(Date_Echeance_IR)<day(getdate())) and (month(Date_Echeance_IR)=month(getdate()) and (year(Date_Echeance_IR))=year(getdate()))").AsEnumerable().First(),
        Interet_Retard_Annee_EnCours = _db.Database.SqlQuery<decimal>($"select ISNULL(SUM(mont_calc_ir),0) from T_CALC_INT_IR where REF_CTR_CALC_IR= {ref_ctr} and (month(Date_Echeance_IR)<month(getdate())  and (year(Date_Echeance_IR))=year(getdate()))").AsEnumerable().First(),
        Instruments_Paiement_Impayes = 0, // TODO: Add your logic here
        Retard_Paiement_Algorithme = (decimal)sumOfMnt.SumMntFactDepAlgo, 
        Litiges_Overts_Depassement = (decimal)sumOfMnt.SumMntLitige, 
        Total_Dispo2 = totalfact - total_ctr_fin - Avoir - comfact - t_fraisdiversC - t_fraisdivers - t_fraisdiversT - t_fraisdiversV + t_credit - t_debit - FDG - dep_limite - FDR - total_intert - total_retenu - interet_par_an - interet_retard_par_an - total_intert_de_retard - a - b - c,
        Total_Facture = (decimal)all.Total_Facture,
        Total_Financement = (decimal)all.Total_Financement,
        Total_Avoir = (decimal)all.Total_Avoir,
        Total_Com8factoring = (decimal)all.Total_Commission,
        Total_Frais_Divers = (decimal)t_fraisdivers,
        Total_Frais = (decimal)(t_fraisdiversT + t_fraisdiversV + t_fraisdiversC),
        Total_Credit = (decimal)all.Total_Credit,
        Total_Debit = (decimal)all.Total_Debit,
        Total_Financement_Rapport_Enc = montFinEncours,
        Total_Interet_TTC = (decimal)all.Total_Interet,
        Total_Interet_Retard_TTC = (decimal)all.Total_IR_All_annee,
        //Financement_Mois = (decimal)listeachatsfina.Sum(x => x.montant_financement),
        Total_Retenu = (decimal)all.Total_Retenue
    };

    return financementDto;
}
}