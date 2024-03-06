using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_CALC_INT_IR
{
    public int ID_CALC_IR { get; set; }

    public int? REF_CTR_CALC_IR { get; set; }

    public string REF_DOCUMENT_DET_BORD_IR { get; set; }

    public decimal? MONT_OUV_DET_BORD_IR { get; set; }

    public DateTime? Date_Echeance_IR { get; set; }

    public int? MAJOR_INT_INT_FIN_IR { get; set; }

    public decimal? MONT_CALC_IR { get; set; }
}
