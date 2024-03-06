using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_PROROGATION
{
    public int REF_CTR_PROG { get; set; }

    public string TYP_PROG { get; set; }

    public string MOTIF_PROG { get; set; }

    public DateTime? DAT_PROG { get; set; }

    public DateTime ECH_PROG { get; set; }

    public bool? ETAT_PROG { get; set; }

    public int ID_DET_BORD_PROG { get; set; }

    public int ID_PROROGATION { get; set; }
}
