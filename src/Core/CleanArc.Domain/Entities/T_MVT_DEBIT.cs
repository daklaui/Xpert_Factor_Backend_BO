﻿using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_MVT_DEBIT
{
    public int ID_DEBIT { get; set; }

    public int REF_CTR_DEBIT { get; set; }

    public string ABEV_DEBIT { get; set; }

    public string TYP_DEBIT { get; set; }

    public decimal? MONT_DEBIT { get; set; }

    public DateTime? DATE_DEBIT { get; set; }
}
