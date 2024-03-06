using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_MOTIF_LIT
{
    public int REF_CTR_MOTIF_LIT { get; set; }

    public string TYP_MOTIF_LIT { get; set; }

    public string LIB_MOTIF_LIT { get; set; }

    public short? DELAI_RESOL_MOTIF_LIT { get; set; }

    public bool? RETRO_AUTO_MOTIF_LIT { get; set; }

    public bool? ALERTE_LIT_MOTIF_LIT { get; set; }

    public bool? FRAIS_MOTIF_LIT { get; set; }

    public string LOGIN_USER_MOTIF_LIT { get; set; }
}
