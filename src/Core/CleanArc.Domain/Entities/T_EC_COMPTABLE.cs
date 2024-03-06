using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_EC_COMPTABLE
{
    public int ID_EC_CPT { get; set; }

    public string TYP_TR_EC_CPT { get; set; }

    public DateTime? DAT_SAIS_EC_CPT { get; set; }

    public DateTime? DAT_EFF_EC_CPT { get; set; }

    public decimal? MONT_EC_CPT { get; set; }

    public string REF_EC_CPT { get; set; }

    public string DESC_EC_CPT { get; set; }

    public string ID_USER_EC_EPT { get; set; }

    public string LOT_EC_CPT { get; set; }

    public string DEVISE_EC_CPT { get; set; }

    public string CODE_ENT_EC_CPT { get; set; }

    public long? LIGNE_EC_CPT { get; set; }

    public int? REF_ADH_EC_CPT { get; set; }

    public string TYP_DOC_EC_CPT { get; set; }

    public string COD_JOURNAL_EC_CPT { get; set; }

    public string SEQ_COD_JOURNAL_EC_CPT { get; set; }

    public string DECS_SRC_CG_EC_CPT { get; set; }

    public string DOMAINE_EC_CPT { get; set; }
}
