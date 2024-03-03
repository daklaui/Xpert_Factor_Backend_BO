using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRibFactor:BaseEntity,IEntity
{
    public int IdRibFactor { get; set; }
    public string RibFactor { get; set; }
    public byte ValidRibFactor { get; set; }
    public virtual ICollection<TFactor> Factors { get; set; }
    
    
}