using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_FRAIS_PAIEMENT : IEntity
{
    public string TYP_FRAIS_PAIE { get; set; }

    public int REF_CTR_FRAIS_PAIE { get; set; }

    public decimal? MONT_PAR_INSTR_FRAIS_PAIE { get; set; }

    public string LIB_FRAIS_PAIE { get; set; }
}
