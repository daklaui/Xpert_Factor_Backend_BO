using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_IMPAYE
{
    public int ID_IMP { get; set; }

    public int ID_ENC_IMP { get; set; }

    public int? ID_DET_BORD_IMP { get; set; }

    public DateTime? DATE_IMP { get; set; }

    public DateTime? DATE_SAISI_IMP { get; set; }

    public decimal? MONT_IMP { get; set; }

    public DateTime? DATE_RESOL_IMP { get; set; }

    public string ID_NV_ENCS { get; set; }

    public bool? IS_RESOLU { get; set; }
}
