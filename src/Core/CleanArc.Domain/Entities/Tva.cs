using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRTva:BaseEntity,IEntity
{
    public int IdT{ get; set; }
    public String  LibT{ get; set; }
    public decimal  ValT{ get; set; }
    public virtual ICollection<TFactor> Factors { get; set; }

}