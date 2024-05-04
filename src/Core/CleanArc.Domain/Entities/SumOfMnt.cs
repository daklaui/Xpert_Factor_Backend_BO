using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.Entities;
[Keyless]
public class SumOfMnt
{
    public Decimal? SumMntImpaye { get; set; }
    public Decimal? SumMntLitige { get; set; }
    public Decimal? SumMntFactDepAlgo { get; set; }
    public Decimal? FIN_MOIS_CTR { get; set; }
    public Decimal? Disponible_Sans_FDG_Libérer { get; set; }
    public Decimal? FDG_Libérer_From_T_Finacement { get; set; }
    public Decimal? Financemnt_Sans_FDG_Libérer { get; set; }
    public Decimal? Sum_FDG_Libérer { get; set; }
}