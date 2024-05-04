using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.StoredProcuderModel;

[Keyless]
public class UspEtatDepassLimACHResult
{
    public decimal DepassLim { get; set; }
}