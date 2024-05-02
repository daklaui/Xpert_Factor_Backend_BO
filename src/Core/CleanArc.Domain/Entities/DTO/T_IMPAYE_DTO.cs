using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.Entities.DTO;
[Keyless]

public class T_IMPAYE_DTO
{
    public int ID_ENC_IMP { get; set; }
    
    public decimal? MONT_IMP { get; set; }

    public DateTime? DATE_IMP { get; set; }
    
    public DateTime? DATE_SAISI_IMP { get; set; }
    
    public string TYP_ENC { get; set; }
    public string ADR_IND { get; set; }
    
    public string NOM_IND { get; set; }
}