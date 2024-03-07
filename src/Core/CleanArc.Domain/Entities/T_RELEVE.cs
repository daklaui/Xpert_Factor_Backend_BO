using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_RELEVE
{
    public int ID_RELEVE { get; set; }

    public string ADH_RELEVE { get; set; }

    public string Contrat_RELEVE { get; set; }

    public string PP_RELEVE { get; set; }

    public string Libelle_OP_RELEVE { get; set; }

    public decimal? Credit_RELEVE { get; set; }

    public decimal? debit_RELEVE { get; set; }

    public decimal? autre_RELEVE { get; set; }

    public DateTime? Date_OP_RELEVE { get; set; }

    public string Encours_Facture_RELEVE { get; set; }

    public string Disponible_RELEVE { get; set; }

    public DateTime? Date_RELEVE { get; set; }
}
