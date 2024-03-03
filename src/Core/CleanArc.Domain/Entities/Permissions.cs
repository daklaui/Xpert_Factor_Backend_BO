using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TPermissions:BaseEntity,IEntity
{
    public virtual ICollection<TSGrpUser> Groupe { get; set; }
    public virtual ICollection<TRListVal> ListVals { get; set; }

}