using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.Entities;
[Keyless]
public class SumOfMnt
{
    public decimal SumMntImpaye { get; set; }
    public decimal SumMntLitige { get; set; }
    public decimal SumMntFactDepAlgo { get; set; }
}