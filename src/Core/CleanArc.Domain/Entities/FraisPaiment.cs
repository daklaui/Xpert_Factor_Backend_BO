using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFraisPaiment:BaseEntity,IEntity
{
    
    public char TypFraisPaie { get; set; }
    public int RefCtrFraisPaie { get; set; }
    public decimal MontParInstrFraisPaie { get; set; }
    public string  LibFraisPaie { get; set; }
    public virtual ICollection<TContrat> Contrats { get; set; }





    
}