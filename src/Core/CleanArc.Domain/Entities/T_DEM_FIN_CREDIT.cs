using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_DEM_FIN_CREDIT
{
    public int ID_DEM_FIN_CREDIT { get; set; }

    public int ID_CIR_DEM { get; set; }

    public decimal? MONT_FIN_DEM { get; set; }

    public decimal? MONT_FIN_ACC { get; set; }

    public DateTime? DAT_FIN_ACC { get; set; }

    public decimal? MONT_CREDIT_DEM { get; set; }

    public decimal? MONT_CREDIT_ACC { get; set; }

    public DateTime? DAT_CREDIT_ACC { get; set; }
}
