using CleanArc.Domain.Common;
using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TR_RIB : IEntity
{
    public string RIB_RIB { get; set; }

    public int REF_IND_RIB { get; set; }

    public bool? ACTIF_RIB { get; set; }
}
