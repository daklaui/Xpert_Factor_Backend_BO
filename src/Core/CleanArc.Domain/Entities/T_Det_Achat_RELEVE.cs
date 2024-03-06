using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_Det_Achat_RELEVE
{
    public int ID_Det_Achat_REL { get; set; }

    public string nom_ind_Det_Achat_REL { get; set; }

    public int? REF_CTR_Det_Achat_REL { get; set; }

    public string TYP_DET_BORD_Det_Achat_REL { get; set; }

    public string num_bord_Det_Achat_REL { get; set; }

    public string ref_document_Det_Achat_REL { get; set; }

    public decimal? MONT_TTC_Det_Achat_REL { get; set; }

    public DateTime? DAT_DET_BORD_Det_Achat_REL { get; set; }

    public DateTime? DAT_ECHEANCE_Det_Achat_REL { get; set; }

    public decimal? MONT_TTC_COMM_Det_Achat_REL { get; set; }

    public decimal? TX_COMM_Det_Achat_REL { get; set; }

    public DateTime? DAT_BORD_Det_Achat_REL { get; set; }
}
