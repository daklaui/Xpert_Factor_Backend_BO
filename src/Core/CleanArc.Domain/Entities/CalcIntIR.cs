using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TCalcIntIR:BaseEntity,IEntity
{
    public int RefCtrCalcIr { get; set; }
    public string RefDocumentDetBor { get; set; }
    public decimal MontOuvDetBordIr { get; set; }
    public Nullable<System.DateTime> DateEcheanceIr { get; set; }
    public int MajorIntIntFinIr { get; set; }
    public decimal MontCalcIr { get; set; }

    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
}