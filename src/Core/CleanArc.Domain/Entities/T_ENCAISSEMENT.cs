using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_ENCAISSEMENT
{
    public short ID_ENC { get; set; }

    public int REF_CTR_ENC { get; set; }

    public int? REF_ADH_ENC { get; set; }

    public int? REF_ACH_ENC { get; set; }

    public decimal? MONT_ENC { get; set; }

    public string DEVISE_ENC { get; set; }

    public DateTime? DAT_RECEP_ENC { get; set; }

    public DateTime? DAT_VAL_ENC { get; set; }

    public string TYP_ENC { get; set; }

    public bool? VALIDE_ENC { get; set; }

    public string REF_ENC { get; set; }

    public string RIB_ENC { get; set; }

    public string BORD_ENC { get; set; }

    public string REF_SEQ_ENC { get; set; }

    public bool? PREAVIS { get; set; }
}
