using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_COMPTE
{
    public int ID_COMPT { get; set; }

    public int ID_CIR { get; set; }

    public string DEVISE_ACH_CPT { get; set; }

    public decimal? LIM_FIN_ACH_ADH { get; set; }

    public short? DELAI_PAI_CPT { get; set; }

    public string MODE_REG_CPT { get; set; }

    public decimal? TOT_FACT_CPT { get; set; }

    public decimal? FDG_REL_FACT_CPT { get; set; }

    public decimal? DEPASS_LIM_CPT { get; set; }

    public decimal? TOT_LIT_CPT { get; set; }

    public decimal? TOT_IMP_CPT { get; set; }

    public DateTime? DAT_CPT { get; set; }
}
