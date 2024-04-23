using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Identity.Identity.Dtos;

namespace CleanArc.Application.Features.Financement.Queries;

public class GetFinancementRefCtrQueryResult: ICreateMapper<FinancementDto>
{
    public int Total_Dipo { get; set; }
    public int Encours_Factures { get; set; }
    public int Depass_Lim_Ach { get; set; }
    public int Fonds_Reserve{ get; set; }
    public int Interet_Cumule_Mois_EnCours { get; set; }
    public int Interet_Cumule_Annee_EnCours { get; set; }
    public int Interet_Retard_Mois_EnCours { get; set; }
    public int Interet_Retard_Annee_EnCours { get; set; }
    public int Instruments_Paiement_Impayes { get; set; }
    public int Retard_Paiement_Algorithme { get; set; }
    public int Litiges_Overts_Depassement { get; set; }
    public int Total_Dispo2 { get; set; }
    public int Total_Facture { get; set; }
    public int Total_Financement { get; set; }
    public int Total_Avoir { get; set; }
    public int Total_Com8factoring { get; set; }
    public int Total_Frais_Divers { get; set; }
    public int Total_Frais{ get; set; }
    public int Total_Credit { get; set; }
    public int Total_Debit { get; set; }
    public int Total_Financement_Rapport_Enc { get; set; }
    public int Total_Interet_TTC { get; set; }
    public int Total_Interet_Retard_TTC { get; set; }
    public int Financement_Mois { get; set; }
    public int Total_Retenu { get; set; }


}