using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Features.RecouvrementList.Queries.GetAllRecouvrement;

public record GetAllRecouvrementFacturesQuery_Response: ICreateMapper<T_RECOUVREMENT_DTO>
{
    
        public int REF_DOCUMENT_DET_BORD { get; set; }
        public int ID_DET_BORD { get; set; }
        public int REF_CTR_DET_BORD { get; set; }
        public string TYP_DET_BORD { get; set; }
        public DateTime DAT_DET_BORD { get; set; }
        public string DEVISE_DET_BORD  { get; set; }
        public string ECH_DET_BORD { get; set; }
        public string RETENU_DET_BORD { get; set; }
        public string MONT_OUV_DET_BORD { get; set; }
        public string  DELAI_PAIE_DET_BORD { get; set; }
        public string  MODE_REG_DET_BORD { get; set; }
        public int REF_IND_DET_BORD { get; set; }
        public string NOM_IND { get; set; }
        public string NOM_ADH { get; set; }
        public string COMM_DET_BORD { get; set; } 
    
}