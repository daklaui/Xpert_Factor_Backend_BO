using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_ETAT_DISPO
{
    public int ID_ETAT_DISPO { get; set; }

    public int? Ref_Ctr__ETAT_DISPO { get; set; }

    public decimal? Total_Facture_ETAT_DISPO { get; set; }

    public decimal? Total_Fin_ETAT_DISPO { get; set; }

    public decimal? Total_Av_ETAT_DISPO { get; set; }

    public decimal? Total_Comm_ETAT_DISPO { get; set; }

    public decimal? Total_Frais_ETAT_DISPO { get; set; }

    public decimal? Total_Debit_ETAT_DISPO { get; set; }

    public decimal? Total_Credit_ETAT_DISPO { get; set; }

    public decimal? Total_Interet_ETAT_DISPO { get; set; }

    public decimal? Depass_Limite_ETAT_DISPO { get; set; }

    public decimal? Total_Retenue_ETAT_DISPO { get; set; }

    public decimal? Total_FDG_ETAT_DISPO { get; set; }

    public decimal? Disponible_ETAT_DISPO { get; set; }

    public DateTime? Date_ETAT_DISPO { get; set; }

    public decimal? Total_Encours_Facture_ETAT_DISPO { get; set; }

    public decimal? Total_IR_ETAT_DIPOS { get; set; }

    public decimal? Total_Instru_Paiments_Imp_ETAT_DIPOS { get; set; }

    public decimal? Total_Retard_Paiement_Algo_ETAT_DISPO { get; set; }

    public decimal? Total_Litiges_ouvert_ETAT_DISPO { get; set; }

    public decimal? Total_Disponible_2_ETAT_DISPO { get; set; }

    public decimal? Total_Fonds_Reserve_ETAT_DISPO { get; set; }

    public decimal? Total_Financement_du_mois_ETAT_DISPO { get; set; }
}
