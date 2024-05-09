using CleanArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.DTO;
[Keyless]
    public partial class ListeDesContrats_Result
    {
        public int ID_CIR { get; set; }


        public int REF_CTR_CIR { get; set; }


        public int REF_IND_CIR { get; set; }


        public string ID_ROLE_CIR { get; set; }


        public int REF_CTR { get; set; }


        public string STATUT_CTR { get; set; }
 

        public string REF_CTR_PAPIER_CTR { get; set; }


        public bool? SERVICE_CTR { get; set; }


        public string TYP_CTR { get; set; }


        public string TYPE_OF_CTR { get; set; }


        public DateTime? DAT_SIGN_CTR { get; set; }


        public DateTime? DAT_DEB_CTR { get; set; }


        public DateTime? DAT_RESIL_CTR { get; set; }


        public DateTime? DAT_PROCH_VERS_CTR { get; set; }


        public DateTime? DAT_CREATION_CTR { get; set; }


        public decimal? CA_CTR { get; set; }


        public decimal? CA_EXP_CTR { get; set; }


        public decimal? CA_IMP_CTR { get; set; }


        public decimal? LIM_FIN_CTR { get; set; }


        public string DEVISE_CTR { get; set; }


        public short? NB_ACH_PREVU_CTR { get; set; }


        public short? NB_FACT_PREVU_CTR { get; set; }


        public short? NB_AVOIRS_PREVU_CTR { get; set; }


        public short? NB_REMISES_PREVU_CTR { get; set; }


        public short? DELAI_MOYEN_REG_CTR { get; set; }

        public short? DELAI_MAX_REG_CTR { get; set; }


        public bool? FACT_REG_CTR { get; set; }


        public decimal? DERN_MONT_DISP_2 { get; set; }


        public decimal? MIN_COMM_FACT { get; set; }


        public string Adherent { get; set; }


        public string Resp_Ctr { get; set; }


        public decimal? Encours_Factures { get; set; }


        public decimal? Somme_Factures { get; set; }


        public decimal? Somme_Bordereaux { get; set; }


        public int? Nombre_Factures { get; set; }


        public int? Nombre_Bordereaux { get; set; }


        public int? Nombre_Acheteurs { get; set; }


        public decimal? Totla_Encaissements { get; set; }


        public decimal? Totlal_Avoirs { get; set; }


        public decimal? Total_Fianancements { get; set; }


        public decimal? Total_interet { get; set; }
    }