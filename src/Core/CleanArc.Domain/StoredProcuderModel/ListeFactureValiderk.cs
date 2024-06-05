﻿using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.StoredProcuderModel;

[Keyless]
public class ListeFactureValiderk
{
    
        public string REF_DOCUMENT_DET_BORD { get; set; }
        public string ID_DET_BORD { get; set; }
        public int REF_CTR_DET_BORD { get; set; }
        public Nullable<int> REF_ADH_BORD { get; set; }
        public string TYP_DET_BORD { get; set; }
        public string NUM_CREANCE_ASS_BORD { get; set; }
        public string TYP_ASS_DET_BORD { get; set; }
        public Nullable<System.DateTime> DAT_DET_BORD { get; set; }
        public Nullable<decimal> MONT_TTC_DET_BORD { get; set; }
        public string DEVISE_DET_BORD { get; set; }
        public Nullable<short> ECH_DET_BORD { get; set; }
        public decimal RETENU_DET_BORD { get; set; }
        public Nullable<decimal> MONT_OUV_DET_BORD { get; set; }
        public Nullable<short> DELAI_PAIE_DET_BORD { get; set; }
        public string MODE_REG_DET_BORD { get; set; }
        public Nullable<int> REF_IND_DET_BORD { get; set; }
        public string NOM_IND { get; set; }
        public string NOM_IND1 { get; set; }
  
    
}