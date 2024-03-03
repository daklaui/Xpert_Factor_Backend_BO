using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TImpaye :BaseEntity ,IEntity
{
    public int IdImp { get; set; }
    public int IdEncImp { get; set; }
    public int IdDetBordImp { get; set; }
    public Nullable<System.DateTime> DateImp { get; set; }
    public Nullable<System.DateTime> DateSaisiImp { get; set; }
    public decimal MontImp { get; set; }
    public Nullable<System.DateTime> DateResolImp { get; set; }
    public string IdNvEncs { get; set; }
    public bool IsResolu { get; set; }
    public TEncaissement Encaissement { get; set; } 
}