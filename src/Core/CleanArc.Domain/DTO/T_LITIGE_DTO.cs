using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.Entities.DTO;

[Keyless]
public class T_LITIGE_DTO
{
    public int ID_LITIGE { get; set; }
    public string REF_IND { get; set; }
    public string NOM_IND { get; set; }
    public string TYP_DET_BORD { get; set; }
    public string ID_DET_BORD { get; set; }
    public decimal MONT_OUV_DET_BORD { get; set; }
    public DateTime ECH_LIT { get; set; }
    public decimal MONT_LT { get; set; }
}
