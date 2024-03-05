using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRibFactor:BaseEntity,IEntity
{
    public string RibFactor { get; set; }
    public byte ValidRibFactor { get; set; }
    
    public int idFactor { get; set; }
    public  TFactor Factor { get; set; }= null!;
    
    
}