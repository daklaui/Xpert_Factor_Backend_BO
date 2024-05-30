namespace CleanArc.Domain.DTO;

public class BuyerDTO
{
  
    public int REF_CTR_CIR { get; set; }
    public int REF_IND_CIR { get; set; }

    
    public DateTime DAT_DEM_LIM_ASS { get; set; }
    public DateTime DAT_DEM_LIM_FIN { get; set; }
    public decimal? MONT_LIM_FIN { get; set; }
    public decimal? MONT_LIM_ASS { get; set; }
    
}

