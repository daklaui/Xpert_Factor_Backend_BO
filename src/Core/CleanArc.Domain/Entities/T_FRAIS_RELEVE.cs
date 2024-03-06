using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_FRAIS_RELEVE
{
    public int ID_FRAIS_REL { get; set; }

    public int? REF_CTR_ { get; set; }

    public DateTime? dat_recep_enc { get; set; }

    public string typ_enc { get; set; }

    public int? Nb_piéce { get; set; }

    public decimal? MONT_PAR_INSTR_FRAIS_PAIE { get; set; }

    public decimal? TVA { get; set; }

    public decimal? TAXTVA { get; set; }

    public decimal? TTCPP { get; set; }

    public decimal? MNTTTCT { get; set; }
}
