using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TR_TMM
{
    public DateTime? DATE_DEBUT_TMM { get; set; }

    public DateTime? DATE_FIN_TMM { get; set; }

    public decimal? TAUX_TMM { get; set; }

    public int ID_TMM { get; set; }
}
