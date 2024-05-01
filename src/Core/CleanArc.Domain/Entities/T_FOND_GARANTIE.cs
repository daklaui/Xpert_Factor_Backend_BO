﻿using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_FOND_GARANTIE : IEntity
{
    public string TYP_FDG { get; set; }

    public int REF_CTR_FDG { get; set; }

    public string LIB_FDG { get; set; }

    public decimal? TX_FDG { get; set; }

    public decimal? MONT_MAX_FDG { get; set; }

    public decimal? MONT_MIN_FDG { get; set; }

    public string TYP_DOC_REMIS_FDG { get; set; }
}
