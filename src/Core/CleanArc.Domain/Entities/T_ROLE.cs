using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_ROLE
{
    public string ID_ROLE { get; set; }

    public string LIB_ROLE { get; set; }

    public virtual ICollection<TJ_CIR> TJ_CIRs { get; } = new List<TJ_CIR>();
}
