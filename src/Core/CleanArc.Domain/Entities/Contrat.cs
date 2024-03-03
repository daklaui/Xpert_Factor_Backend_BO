using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TContrat:BaseEntity,IEntity
{
    public int RefCtr { get; set; }
    public string StatutCtr { get; set; }
    public string RefCtrPapierCtr { get; set; }
    public byte ServiceCtr { get; set; }
    public Nullable<System.DateTime> DatSignCtr { get; set; }
    public Nullable<System.DateTime> datDebCtr { get; set; }
    public Nullable<System.DateTime> datResilCtr { get; set; }
    public Nullable<System.DateTime> datProchVersCtr { get; set; }
    public decimal CaCtr { get; set; }
    public decimal CaExpCtr { get; set; }
    public decimal CaImpCtr { get; set; }
    public decimal LimFinCtr { get; set; }
    public char DeviseCtr { get; set; }
    public int NbAchPrevuCtr { get; set; }
    public int NbFactPrevuCtr { get; set; }
    public int NbAvoirsPrevuCtr { get; set; }
    public int NbRemisesPrevuCtr { get; set; }
    public int DelaiMoyenRegCtr { get; set; }
    public int DelaiMaxRegCtr { get; set; }
    public byte FactRegCtr { get; set; }
    public decimal DernMontDisp2 { get; set; }
    public TFraisPaiment FraisPaiment { get; set; }
    public virtual ICollection<TFraisDivers> FraisDivers { get; set; }
    public virtual ICollection<TComFactoring> ComFactorings{ get; set; }
    public TFinancement Financement { get; set; }
    public TMvtDebit MvtDebit { get; set; }
    public TCalcInt  CalcInt { get; set; }
    public TIntFinancement IntFinancement { get; set; }
    public TFraisReleve FraisReleve { get; set; }
    public TRelance Relance { get; set; }
    public TLitige Litige { get; set; }
    public TMvtCredit MvtCredit { get; set; }
    public TEcCpt EcCpt { get; set; }
    public TEtatDispo EtatDispo { get; set; }
    public TBordereau Bordereau { get;set; }
    public virtual ICollection<TFactor> Factors { get; set; }
    public TCalcDispo CalcDispo { get; set; }
    public TCalcIntIR CalcIntIr { get; set; }
    public TDetBord DetBord { get; set; }
    


}