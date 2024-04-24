using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_COMM_FACTORING : IEntity
{
    public string TYP_COMM_FACTORING { get; set; }

    public int REF_CTR_COMM_FACTORING { get; set; }

    public decimal? TX_COMM_FACTORING { get; set; }

    public decimal? MONT_MIN_DOC_COMM_FACTORING { get; set; }

    public decimal? MONT_MIN_CTR_COMM_FACTORING { get; set; }
}
