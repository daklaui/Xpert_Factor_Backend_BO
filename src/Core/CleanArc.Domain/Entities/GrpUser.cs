using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TSGrpUser:BaseEntity,IEntity
{   
public string LibGrpUser { get; set; }
public byte ActifGrpUser { get; set; }

 public  ICollection<TPermissions> Permissions { get; } = new List<TPermissions>();
 
 public int GroupeId { get;set; } 
 public TGroupe groupe { get;set; } 

 public  ICollection<TUser> TUsers { get; } = new List<TUser>();

}