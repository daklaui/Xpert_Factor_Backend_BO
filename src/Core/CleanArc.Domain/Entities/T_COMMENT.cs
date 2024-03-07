using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_COMMENT
{
    public int ID_COMMENT { get; set; }

    public string ACTION { get; set; }

    public string COMMENT { get; set; }

    public DateTime DATE_COMMENT { get; set; }

    public DateTime? DATE_TRAITE_COMMENT { get; set; }

    public string VALIDATION_TYPE { get; set; }

    public bool IS_RESOLVED { get; set; }

    public int ID_ACTION { get; set; }

    public int? REF_CTR_ACTION { get; set; }
}
