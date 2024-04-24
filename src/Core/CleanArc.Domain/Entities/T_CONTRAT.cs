using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_CONTRAT : IEntity
{
    public int REF_CTR { get; set; }

    public string STATUT_CTR { get; set; }

    public string REF_CTR_PAPIER_CTR { get; set; }

    public bool? SERVICE_CTR { get; set; }

    public string TYP_CTR { get; set; }

    public DateTime? DAT_SIGN_CTR { get; set; }

    public DateTime? DAT_DEB_CTR { get; set; }

    public DateTime? DAT_RESIL_CTR { get; set; }

    public DateTime? DAT_PROCH_VERS_CTR { get; set; }

    public decimal? CA_CTR { get; set; }

    public decimal? CA_EXP_CTR { get; set; }

    public decimal? CA_IMP_CTR { get; set; }

    public decimal? LIM_FIN_CTR { get; set; }

    public string DEVISE_CTR { get; set; }

    public short? NB_ACH_PREVU_CTR { get; set; }

    public short? NB_FACT_PREVU_CTR { get; set; }

    public short? NB_AVOIRS_PREVU_CTR { get; set; }

    public short? NB_REMISES_PREVU_CTR { get; set; }

    public short? DELAI_MOYEN_REG_CTR { get; set; }

    public short? DELAI_MAX_REG_CTR { get; set; }

    public bool? FACT_REG_CTR { get; set; }

    public decimal? DERN_MONT_DISP_2 { get; set; }

    public decimal? MIN_COMM_FACT { get; set; }

    public bool? IS_NOTIFIED { get; set; }

    public string OLD_STATUT_CTR { get; set; }

    public DateTime? DAT_CREATION_CTR { get; set; }

    public int? RESP_CTR_1 { get; set; }

    public int? RESP_CTR_2 { get; set; }
    
   

    public virtual ICollection<TJ_CIR> TJ_CIRs { get; } = new List<TJ_CIR>();

    public virtual ICollection<T_CALC_INT> T_CALC_INTs { get; } = new List<T_CALC_INT>();

    public virtual ICollection<T_DET_BORD> T_DET_BORDs { get; } = new List<T_DET_BORD>();
}
