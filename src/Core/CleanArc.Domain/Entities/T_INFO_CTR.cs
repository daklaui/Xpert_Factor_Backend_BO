using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_INFO_CTR
{
    public int ID_INFO_CTR { get; set; }

    public int? REF_INFO_CTR { get; set; }

    public string LIBELLE_INFO_CTR { get; set; }

    public DateTime? DATE_INFO_CTR { get; set; }

    public int? ID_USER_INFO_CTR { get; set; }
}
