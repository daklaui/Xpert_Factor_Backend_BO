using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_BORD_FACTOR
{
    public int ID_BORD_FACTOR { get; set; }

    public string NUM_BORD_FACTOR { get; set; }

    public int? ID_FACTOR_BORD_FACTOR { get; set; }

    public int REF_CTR_BORD_FACTOR { get; set; }

    public decimal? MONT_TOT_BORD_FACTOR { get; set; }

    public DateTime? DAT_CRE_BORD_FACTOR { get; set; }

    public DateTime? DAT_EDIT_BORD_FACTOR { get; set; }

    public bool VALID_BORD_FACTOR { get; set; }

    public int? ID_ENC_BORD_FACTOR { get; set; }

    public string REF_ENC_BORD_FACTOR { get; set; }
}
