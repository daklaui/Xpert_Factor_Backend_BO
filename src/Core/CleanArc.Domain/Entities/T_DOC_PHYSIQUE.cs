using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_DOC_PHYSIQUE
{
    public string TYP_DOC_PHY { get; set; }

    public int REF_CTR_DOC_PHY { get; set; }

    public DateTime? DAT_VALID_DOC_PHY { get; set; }

    public DateTime? DAT_EXPIR_DOC_PHY { get; set; }

    public bool? DOC_BLOQ_DOC_PHY { get; set; }

    public string REF_USER_DOC_PHY { get; set; }

    public bool? DOC_RECU_DOC_PHY { get; set; }

    public bool? IS_SENT { get; set; }
}
