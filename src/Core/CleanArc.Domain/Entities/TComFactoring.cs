using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TComFactoring:BaseEntity,IEntity
{
    public char  TypCommFactoring{ get; set; }
    public char  TxCommFactoring{ get; set; }
    public decimal MontMinDocCommFactoring{ get; set; }
    public decimal MontMinCtrCommFactoring{ get; set; }
    public int RefCtrCommFactoring{ get; set; }
    public TContact Contact { get; set; }
    public TFraisDivers FraisDivers { get; set; }
    
}