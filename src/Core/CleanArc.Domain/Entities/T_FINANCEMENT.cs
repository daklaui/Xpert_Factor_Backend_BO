﻿using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_FINANCEMENT
{
    public int ID_FIN { get; set; }

    public int? REF_CTR_FIN { get; set; }

    public int? REF_ADH_FIN { get; set; }

    public decimal? MONT_FIN { get; set; }

    public DateTime? DAT_FIN { get; set; }

    public string INSTR_FIN { get; set; }

    public string REF_INSTR_FIN { get; set; }

    public DateTime? DAT_INSTR_FIN { get; set; }

    public string ETAT_FIN { get; set; }

    public int? ID_DISPO_FIN { get; set; }

    public string TYPE_ENC { get; set; }
}
