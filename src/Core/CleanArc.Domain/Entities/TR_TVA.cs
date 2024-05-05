using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class TR_TVA : IEntity
{
    public short ID_TVA { get; set; }

    public string LIB_TVA { get; set; }

    public decimal? VAL_TVA { get; set; }
}
