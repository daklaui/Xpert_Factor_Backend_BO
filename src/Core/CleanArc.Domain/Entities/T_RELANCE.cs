using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_RELANCE
{
    public int ID_RELANCE { get; set; }

    public string REF_CTR_RELANCE { get; set; }

    public string LIBELLE_RELANCE { get; set; }

    public DateTime? DATE_RELANCE { get; set; }

    public string REF_DOC_RELANCE { get; set; }

    public bool? VALIDE_RELANCE { get; set; }

    public string USER_RELANCE { get; set; }
}
