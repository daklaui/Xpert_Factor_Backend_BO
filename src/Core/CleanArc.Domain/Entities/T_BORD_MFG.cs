using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_BORD_MFG
{
    public int ID_BORD_MFG { get; set; }

    public int? REF_CTR_BORD_MFG { get; set; }

    public int? REF_ADH_BORD_MFG { get; set; }

    public string NOM_ADH_BORD_MFG { get; set; }

    public string NUM_BORD_MFG { get; set; }

    public decimal? MNT_COMM_HT_BORD_MFG { get; set; }

    public DateTime? DATE_BORD_MFG { get; set; }

    public DateTime? DATE_ENVOIE_BORD_MFG { get; set; }
}
