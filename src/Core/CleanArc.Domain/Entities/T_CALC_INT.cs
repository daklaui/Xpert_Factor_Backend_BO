using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_CALC_INT
{
    public int ID_CALC_INT { get; set; }

    public int REF_CTR_CALC_INT { get; set; }

    public decimal? MONT_CALC_INT { get; set; }

    public DateTime? DAT_CALC_INT { get; set; }

    public virtual T_CONTRAT REF_CTR_CALC_INTNavigation { get; set; }
}
