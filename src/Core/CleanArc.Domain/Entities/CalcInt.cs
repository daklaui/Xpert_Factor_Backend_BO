using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TCalcInt :BaseEntity,IEntity
{
    public decimal MontCalcInt{ get; set; }
    public Nullable<System.DateTime> DatCalcInt { get; set; }
    
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
}