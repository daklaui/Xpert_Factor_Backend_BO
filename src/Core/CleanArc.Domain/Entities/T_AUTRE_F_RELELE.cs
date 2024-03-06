using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_AUTRE_F_RELELE
{
    public int ID_AUTRE_F_REL { get; set; }

    public int? REF_CTR_AUTRE_F_REL { get; set; }

    public string ABEV_AUTRE_F_REL { get; set; }

    public decimal? MONT_AUTRE_F_REL { get; set; }

    public string nom_ind_AUTRE_F_REL { get; set; }

    public DateTime? DATE_AUTRE_F_REL { get; set; }
}
