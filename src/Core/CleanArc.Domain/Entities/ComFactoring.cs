using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRComFactoring :BaseEntity,IEntity
{
    
    public char  TypCommFactoring{ get; set; }
    public char  TxCommFactoring{ get; set; }
    public decimal MontMinDocCommFactoring{ get; set; }
    public decimal MontMinCtrCommFactoring{ get; set; }
    public int IdCommFactoring{ get; set; }
    public virtual ICollection<TFactor> Factors { get; set; }
    
}