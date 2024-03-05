using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TGroupe : BaseEntity, IEntity
{
    public string NomGro { get; set; }
    public  ICollection<TSGrpUser> TsGrpUsers { get; } = new List<TSGrpUser>();
}