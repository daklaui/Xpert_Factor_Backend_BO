using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_EC_CPT
{
    public int ID_EC_CPT { get; set; }

    public int? ANNEE_EC_CPT { get; set; }

    public string CODE_DEP_EC_CPT { get; set; }

    public string NUM_EC_EC_CPT { get; set; }

    public byte? NUM_LIGNE_EC_CPT { get; set; }

    public string CODE_JOURNAL_EC_CPT { get; set; }

    public DateTime? DATE_SAISIE_EC_CPT { get; set; }

    public DateTime? DATE_EFFET_EC_CPT { get; set; }

    public string LIBELLEE_EC_CPT { get; set; }

    public string COMPTE_GEN_EC_CPT { get; set; }

    public decimal? MONTANT_EC_CPT { get; set; }

    public string CODE_CENTRE_ANALYSE_EC_CPT { get; set; }

    public string REF_PIECE_EC_CPT { get; set; }

    public string TYPE_TRANSACTION_EC_CPT { get; set; }

    public string TYPE_DOC_EC_CPT { get; set; }

    public string NOM_USER_EC_CPT { get; set; }

    public string LOT_EC_CPT { get; set; }

    public string CODE_TIERS_EC_CPT { get; set; }

    public string DOMAINE_EC_CPT { get; set; }

    public decimal? CREDIT_EC_CPT { get; set; }

    public DateTime? DATE_EC_CPT { get; set; }

    public int? REF_ADH_EC_CPT { get; set; }

    public string COMPTE_EC_CPT { get; set; }

    public string CODE_EC_CPT { get; set; }

    public string INTITULE_EC_CPT { get; set; }

    public string REF_MFG_ADH_EC_CPT { get; set; }

    public int ID_ECCPT { get; set; }
}
