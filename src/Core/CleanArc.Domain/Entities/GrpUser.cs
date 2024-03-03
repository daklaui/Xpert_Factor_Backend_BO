using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TSGrpUser:BaseEntity,IEntity
{   
public int Id { get; set; } 
public string LibGrpUser { get; set; }
public byte ActifGrpUser { get; set; }
public ICollection<TGroupe> Groupe { get; set; }
public TUser User { get; set; }

}