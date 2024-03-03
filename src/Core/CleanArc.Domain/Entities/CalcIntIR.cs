using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TCalcIntIR:BaseEntity,IEntity
{
    public int IdCalcIr { get; set; }
    public int RefCtrCalcIr { get; set; }
    public string RefDocumentDetBor { get; set; }
    public decimal MontOuvDetBordIr { get; set; }
    public Nullable<System.DateTime> DateEcheanceIr { get; set; }
    public int MajorIntIntFinIr { get; set; }
    public decimal MontCalcIr { get; set; }
    public virtual ICollection<TContrat> Contrats{ get; set; }

}