using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TJ_ADH_WEB
{
    public int ID_WEB { get; set; }

    public int REF_IND_WEB { get; set; }

    public string PRE_IND_WEB { get; set; }

    public string LOGIN_WEB { get; set; }

    public string PWD_WEB { get; set; }

    public DateTime DATE_DEBUT_WEB { get; set; }

    public DateTime? DATE_FIN_WEB { get; set; }
}
