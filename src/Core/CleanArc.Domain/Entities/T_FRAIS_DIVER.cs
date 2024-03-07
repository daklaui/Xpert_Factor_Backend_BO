using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_FRAIS_DIVER
{
    public string TYP_FRAIS_DIVERS { get; set; }

    public int REF_CTR_FRAIS_DIVERS { get; set; }

    public decimal? MONT_PAR_UNIT_FRAIS_DIVERS { get; set; }

    public string LIB_FRAIS_DIVERS { get; set; }
}
