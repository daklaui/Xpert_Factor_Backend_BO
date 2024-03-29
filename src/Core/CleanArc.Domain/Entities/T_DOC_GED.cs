﻿using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_DOC_GED
{
    public int id { get; set; }

    public int? ID_IND_GED { get; set; }

    public int? ID_CTR_GED { get; set; }

    public int? ID_BOR_GED { get; set; }

    public int? ID_DET_BORD_GED { get; set; }

    public int? ID_ENC_GED { get; set; }

    public int? ID_DEBIT_GED { get; set; }

    public int? ID_CREDIT_GED { get; set; }

    public int? ID_FINCANEMENT_GED { get; set; }

    public int? ANNEE_BORD_GED { get; set; }

    public string LIBELLE_GED { get; set; }

    public DateTime DATE_TACHE_GED { get; set; }

    public int? ID_GESTIONNAIRE_GED { get; set; }

    public DateTime? DATE_SCAN_GED { get; set; }

    public string ADRESS_DOC_GED { get; set; }

    public byte[] Data_GED { get; set; }

    public string Name_GED { get; set; }

    public string salle_GED { get; set; }

    public string Armoire_GED { get; set; }

    public string Etgage_GED { get; set; }

    public string Archive_GED { get; set; }

    public string LIBELLE2_GED { get; set; }

    public string ID_Emetteur_GED { get; set; }

    public string Etape_ged { get; set; }

    public bool? Etat_GED { get; set; }
}
