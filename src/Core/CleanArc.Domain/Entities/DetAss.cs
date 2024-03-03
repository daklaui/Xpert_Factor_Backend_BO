using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;


public class TDetAss:BaseEntity,IEntity
{
    public int RefAss { get; set; }
    public int RefCtrAss { get; set; }
    public short PrimeAss { get; set; }
    public short TxCouvertureAss { get; set; }
    public short DelaisDeclarationSinistreAs { get; set; }
    public short ActifAss { get; set; }
}