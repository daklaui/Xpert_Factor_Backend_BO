using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TR_LISTE_FRAIS_DIVER
{
    public string ABREV_FRAIS_DIVERS { get; set; }

    public string LIB_FRAIS_DIVERS { get; set; }

    public decimal? MONT_FRAIS_DIVERS { get; set; }

    public string TYPE_FRAIS_DIVERS { get; set; }

    public int ID_ListeFraisDivers { get; set; }
}
