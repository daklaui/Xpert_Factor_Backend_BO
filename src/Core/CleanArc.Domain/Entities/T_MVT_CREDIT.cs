using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_MVT_CREDIT
{
    public int ID_CREDIT { get; set; }

    public int REF_CTR_CREDIT { get; set; }

    public string ABRV_CREDIT { get; set; }

    public string TYP_CREDIT { get; set; }

    public decimal? MONT_CREDIT { get; set; }

    public DateTime? DATE_CREDIT { get; set; }

    public string LIBELLE_LIBRE_CREDIT { get; set; }

    public string REF_ENC_CREDIT { get; set; }

    public DateTime? DAT_VAL_ENC_CREDIT { get; set; }
}
