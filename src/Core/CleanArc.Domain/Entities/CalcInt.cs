using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TCalcInt :BaseEntity,IEntity
{
    public int IdCalcInt { get; set; }
    public decimal MontCalcInt{ get; set; }
    public Nullable<System.DateTime> DatCalcInt { get; set; }
    public virtual ICollection<TContrat> Contrats{ get; set; }
    
}