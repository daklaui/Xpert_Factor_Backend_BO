using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class TR_Ag_Bq : IEntity
{
    public string Code_Bq_Ag { get; set; }

    public string Code_Bq { get; set; }

    public string Banque { get; set; }

    public string Code_Ag { get; set; }

    public string Agence { get; set; }
}
