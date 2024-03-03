using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TDemLimite :BaseEntity,IEntity
{
    public virtual ICollection<TIndividu>  Individus { get; set; }
    public virtual ICollection<TContact>  Contacts { get; set; }
    public int RefDemLim { get; set; }
    public int RefCtrDemLim { get; set; }
    public string TypDemLim { get; set; }
    public Nullable<System.DateTime> DatDemLim { get; set; }
    public string SortDemLim { get; set; }
    public decimal MontDemLim { get; set; }
    public string Devise { get; set; }
    public Nullable<System.DateTime> DatLastDemLim { get; set; }
    public string DecisionLim { get; set; }
    public decimal MontAcc { get; set; }
    public decimal MontLimAchAdh { get; set; }
    public Nullable<System.DateTime> DatAnnulDemLi { get; set; }
    public Nullable<System.DateTime> DatLimDemLim { get; set; }
    public short DelaisDemLim { get; set; }
    public short DelaisAcc { get; set; }
    public string ModePayDemLim { get; set; }
    public string ModePayAcc { get; set; }
    public bool ActifDemLimi { get; set; }
    public int RefAchLim { get; set; }
}