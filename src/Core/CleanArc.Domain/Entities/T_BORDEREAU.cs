using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_BORDEREAU
{
    public string NUM_BORD { get; set; }

    public int REF_CTR_BORD { get; set; }

    public string ANNEE_BORD { get; set; }

    public int? REF_ADH_BORD { get; set; }

    public int? REF_ACH_BORD { get; set; }

    public DateTime? DAT_BORD { get; set; }

    public short? NB_DOC_BORD { get; set; }

    public decimal? MONT_TOT_BORD { get; set; }

    public string DEVISE_ACH { get; set; }

    public bool? SOLDE_BORD { get; set; }

    public bool? VALIDE_BORD { get; set; }

    public DateTime? DAT_SAISIE_BORD { get; set; }

    public string EMETTEUR { get; set; }
}
