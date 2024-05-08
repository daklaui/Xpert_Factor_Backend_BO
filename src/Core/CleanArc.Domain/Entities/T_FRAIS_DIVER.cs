using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_FRAIS_DIVER : IEntity
{
    public string TYP_FRAIS_DIVERS { get; set; }

    public int REF_CTR_FRAIS_DIVERS { get; set; }

    public decimal? MONT_PAR_UNIT_FRAIS_DIVERS { get; set; }

    public string LIB_FRAIS_DIVERS { get; set; }
}
