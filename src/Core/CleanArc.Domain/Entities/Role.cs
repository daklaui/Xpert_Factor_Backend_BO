using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRole :BaseEntity,IEntity
{
    public string IdRole { get; set; }
    public string LibRole { get; set; }
    public TJCir Cir { get; set; } 
}