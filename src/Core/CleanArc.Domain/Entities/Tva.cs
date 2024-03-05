using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRTva:BaseEntity,IEntity
{
    public string  LibT{ get; set; }
    public decimal  ValT{ get; set; }
    
    public int idFactor { get; set; }
    public  TFactor Factor { get; set; }= null!;

}