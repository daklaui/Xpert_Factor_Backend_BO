using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_MOTIF_PROG
{
    public int REF_CTR_MOTIF_PROG { get; set; }

    public string TYP_MOTIF_PROG { get; set; }

    public string LIB_MOTIF_PROG { get; set; }

    public bool? ALERTE_LIT_MOTIF_PROG { get; set; }

    public DateTime? DAT_MOTIF_PROG { get; set; }

    public DateTime? ECH_MOTIF_PROG { get; set; }

    public bool? FRAIS_MOTIF_PROG { get; set; }

    public string LOGIN_USER_MOTIF_PROG { get; set; }
}
