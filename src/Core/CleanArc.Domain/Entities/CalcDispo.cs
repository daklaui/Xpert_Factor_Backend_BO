using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TCalcDispo :BaseEntity,IEntity
{
    public Nullable<System.DateTime> DateCalcDispo { get; set; }
    public decimal DispoCalcDispo { get; set; }
    public int RefAdhCalcDispo { get; set; }
    public int RefCtrCalcDispo { get; set; }
    public decimal SomFactCalcDispo { get; set; }
    public decimal SomAvoirCalcDispo { get; set; }
    public decimal SomCommFactorCalcDispo { get; set; }
    public decimal SomTvaCommFactorCalcDispo { get; set; }
    public decimal SomDebitCalcDispo { get; set; }
    public decimal SomCreditCalcDispo { get; set; }
    public decimal SomFdgFactCalcDispo { get; set; }
    public decimal SomFdgLibereCalcDispo { get; set; }
    public decimal FinanceCalcDispo { get; set; }
    public decimal InteretJCalcDispo { get; set; }
    public decimal MargeJCalcDispo { get; set; }
    public decimal TmmJCalcDispo { get; set; }
    
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
}