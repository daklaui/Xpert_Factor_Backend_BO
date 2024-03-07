using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TS_GRP_USER
{
    public int ID_GRP_USER { get; set; }

    public string LIB_GRP_USER { get; set; }

    public bool? ACTIF_GRP_USER { get; set; }

    public virtual ICollection<TS_USER> TS_USERs { get; } = new List<TS_USER>();
}
