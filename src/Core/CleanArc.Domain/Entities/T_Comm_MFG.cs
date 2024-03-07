using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_Comm_MFG
{
    public int Id_MFG { get; set; }

    public string Type_MFG { get; set; }

    public string Ref_ADH_MFG { get; set; }

    public string Code_MFG { get; set; }

    public decimal? Mnt_Comm_MFG { get; set; }

    public int? Num_Bord_MFG { get; set; }

    public DateTime? date_Saisie_MFG { get; set; }

    public DateTime? Date_Envoie_MFG { get; set; }

    public bool? Flag_MFG { get; set; }

    public string Type_Action_MFG { get; set; }
}
