using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TR_COMM_FACTORING
{
    public string TYP_COMM_FACTORING { get; set; }

    public string TX_COMM_FACTORING { get; set; }

    public decimal? MONT_MIN_DOC_COMM_FACTORING { get; set; }

    public decimal? MONT_MIN_CTR_COMM_FACTORING { get; set; }

    public int ID_COMM_FACT { get; set; }
}
