using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRole :BaseEntity,IEntity
{
    public string LibRole { get; set; }
    public  ICollection<TJCir> UCirs { get; }= new List<TJCir>();

}