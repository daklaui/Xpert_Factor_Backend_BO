using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TDemLimite :BaseEntity,IEntity
{
  
   
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
    
    
    public int idContact { get; set; } 
    public TContact Contact { get; set; } = null!;
    public int idIndividu { get; set; } 
    public TIndividu Individu { get; set; } = null!;
}