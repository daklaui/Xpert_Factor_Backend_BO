using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TPermissions:BaseEntity,IEntity
{
    public int ListValId { get;set; } 
    public TRListVal TrListVal { get; set; } = null!; 
    
    public int GrpUserId { get;set; } 
    public TSGrpUser GrpUser { get; set; } = null!; 

    
}