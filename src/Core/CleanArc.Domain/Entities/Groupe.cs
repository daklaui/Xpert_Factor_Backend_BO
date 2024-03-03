using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TGroupe : BaseEntity, IEntity
{
    public int TSGrpUserId { get; set; }
    public string NomGro { get; set; }
    public TSGrpUser grpUser{ get; set; }
}