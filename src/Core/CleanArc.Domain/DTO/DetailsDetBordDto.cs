using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.DTO;
[Keyless]
public class DetailsDetBordDto
{
    public string ID_DET_BORD { get; set; }
    public string NUM_BORD { get; set; }
    public string REF_DOCUMENT_DET_BORD { get; set; }
    public string TYP_DET_BORD { get; set; }
    public DateTime? DAT_DET_BORD { get; set; }
    public decimal? MONT_TTC_DET_BORD { get; set; }
    public string ANNEE_BORD { get; set; }
    public int REF_CTR_DET_BORD { get; set; }
    public short? ECH_DET_BORD { get; set; }
    public string MODE_REG_DET_BORD { get; set; }
    public string NOM_IND { get; set; }
    public int REF_IND { get; set; }
    public int? REF_IND_DET_BORD { get; set; }
    public string REF_CTR_PAPIER_CTR { get; set; }
    public int REF_CTR { get; set; }
    public bool? VALIDE_DET_BORD { get; set; }
     
}