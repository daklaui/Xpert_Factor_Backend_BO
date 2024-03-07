using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TJ_LETTRAGE
{
    public int ID_DET_BORD_LET { get; set; }

    public int ID_ENC_LET { get; set; }

    public DateTime DAT_LET { get; set; }

    public decimal? MONT_TTC_LET { get; set; }

    public DateTime? DAT_RECONCIL { get; set; }

    public bool? VALIDE_LET { get; set; }

    public bool? VALIDE_RECONCIL { get; set; }
}
