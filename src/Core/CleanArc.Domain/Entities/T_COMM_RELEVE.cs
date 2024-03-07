using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_COMM_RELEVE
{
    public int ID_COMM_RAP { get; set; }

    public string REF_CTR_COMM_RAP { get; set; }

    public DateTime? DAT_BORD_COMM_RAP { get; set; }

    public string num_bord_COMM_RAP { get; set; }

    public decimal? MONT_COMM_HT_COMM_RAP { get; set; }

    public decimal? TVA_COMM_RAP { get; set; }

    public decimal? MONT_COMM_TVA_COMM_RAP { get; set; }

    public decimal? MONT_COMM_TTC_COMM_RAP { get; set; }
}
