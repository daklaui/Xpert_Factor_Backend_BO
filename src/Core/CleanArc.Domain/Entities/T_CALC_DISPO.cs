using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_CALC_DISPO
{
    public int ID_CALC_DISPO { get; set; }

    public DateTime? DATE__CALC_DISPO { get; set; }

    public decimal? DISPO_CALC_DISPO { get; set; }

    public int? REF_ADH_CALC_DISPO { get; set; }

    public int? REF_CTR_CALC_DISPO { get; set; }

    public decimal? SOM_FACT_CALC_DISPO { get; set; }

    public decimal? SOM_AVOIR_CALC_DISPO { get; set; }

    public decimal? SOM_COMM_FACTOR_CALC_DISPO { get; set; }

    public decimal? SOM_TVA_COMM_FATOR_CALC_DISPO { get; set; }

    public decimal? SOM_DEBIT_CALC_DISPO { get; set; }

    public decimal? SOM_CREDIT_CALC_DISPO { get; set; }

    public decimal? SOM_FDG_FACT_CALC_DISPO { get; set; }

    public decimal? SOM_FDG_LIBERE_CALC_DISPO { get; set; }

    public decimal? FINANCE_CALC_DISPO { get; set; }

    public decimal? INTERET_J_CALC_DISPO { get; set; }

    public decimal? MARGE_J_CALC_DISPO { get; set; }

    public decimal? TMM_J_CALC_DISPO { get; set; }
}
