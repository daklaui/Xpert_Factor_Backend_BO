using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class TR_CP : IEntity
{
    public string CP { get; set; }

    public string Ville { get; set; }

    public string Code_Gouvernorat { get; set; }

    public string Gouvernorat { get; set; }

    public string Code_Region { get; set; }

    public string Region { get; set; }

    public int ID_CP { get; set; }
}
