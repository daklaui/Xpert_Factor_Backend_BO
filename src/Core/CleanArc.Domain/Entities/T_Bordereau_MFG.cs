using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_Bordereau_MFG
{
    public int ID_Bord_MFG { get; set; }

    public string Type_MFG { get; set; }

    public string Ref_ADH_MFG { get; set; }

    public string Ref_ACH_MFG { get; set; }

    public int? Num_Bord_MFG { get; set; }

    public string Ref_Doc_MFG { get; set; }

    public DateTime? Date_Bord_MFG { get; set; }

    public decimal? MONT_TTC_DET_MFG { get; set; }

    public int? Compte_MFG { get; set; }

    public decimal? MONT_FDG_DET_MFG { get; set; }

    public decimal? acc_fourn_adh_MFG { get; set; }

    public decimal? Mnt_Finanancement_MFG { get; set; }

    public DateTime? Date_Creation_MFG { get; set; }

    public DateTime? Date_Envoie_MFG { get; set; }

    public bool? Flag_MFG { get; set; }
}
