using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_DET_ASS : IEntity
{
    public int REF_ASS { get; set; }

    public int? REF_CTR_ASS { get; set; }

    public decimal? PRIME_ASS { get; set; }

    public decimal? TX_COUVERTURE_ASS { get; set; }

    public int? DELAIS_DECALARATION_SINISTRE_ASS { get; set; }

    public bool? ACTIF_ASS { get; set; }
}
