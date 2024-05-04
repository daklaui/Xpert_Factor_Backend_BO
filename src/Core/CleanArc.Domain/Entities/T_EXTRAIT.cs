using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_EXTRAIT : IEntity
{
    public long ID_EXTRAIT { get; set; }

    public int? REF_CTR_EXTRAIT { get; set; }

    public string LIB_EXTRAIT { get; set; }

    public DateTime? DAT_OP_EXTRAIT { get; set; }

    public DateTime? DAT_VAL_EXTRAIT { get; set; }

    public decimal? DEBIT_EXTRAIT { get; set; }

    public decimal? CREDIT_EXTRAIT { get; set; }

    public decimal? ENCOURFACT_EXTRAIT { get; set; }

    public decimal? TOTAL_FIN_EXTRAIT { get; set; }

    public decimal? DISPONIBLE_EXTRAIT { get; set; }

    public decimal? FDG_EXTRAIT { get; set; }

    public decimal? AUTRE_EXTRAIT { get; set; }
}
