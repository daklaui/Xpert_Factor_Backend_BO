using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class TJ_CIR : IEntity
{
    public int ID_CIR { get; set; }

    public int REF_CTR_CIR { get; set; }

    public int REF_IND_CIR { get; set; }

    public string ID_ROLE_CIR { get; set; }

    public virtual T_ROLE ID_ROLE_CIRNavigation { get; set; }

    public virtual T_CONTRAT REF_CTR_CIRNavigation { get; set; }

    public virtual T_INDIVIDU REF_IND_CIRNavigation { get; set; }
    
}
