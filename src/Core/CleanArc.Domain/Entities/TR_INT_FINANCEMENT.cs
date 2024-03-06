using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TR_INT_FINANCEMENT
{
    public string TYP_INSTR_INT_FIN { get; set; }

    public decimal? TX_INT_MARCHE_INT_FIN { get; set; }

    public decimal? TX_MARGE_CTR_INT_FIN { get; set; }

    public short? DELAI_MAX_PAI_INT_FIN { get; set; }

    public decimal? PRECOMPTE_INT_FIN { get; set; }

    public decimal? MAJOR_INT_INT_FIN { get; set; }

    public DateTime? DAT_DEB_VALID_INT_FIN { get; set; }

    public int ID_TR_INT_FIN { get; set; }
}
