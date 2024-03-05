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
    
    public int idFactor { get; set; }
    public  TFactor Factor { get; set; }= null!;
    
    public int idDetAss { get; set; }
    public  TDetAss DetAss { get; set; }= null!;
    
    public int idFraisDivers { get; set; }
    public  TFraisDivers FraisDivers { get; set; }= null!;
    
    
    public  ICollection<TEncaissement> Encaissementss { get; }= new List<TEncaissement>();
    public  ICollection<TPropagation> Propagations { get; }= new List<TPropagation>();
    public  ICollection<TFondGarantie> FondGaranties { get; }= new List<TFondGarantie>();
    public  ICollection<TComMfg> ComMfgs { get; }= new List<TComMfg>();
    public  ICollection<TRelance> Relances { get; }= new List<TRelance>();
    public  ICollection<TLitige> Litiges { get; }= new List<TLitige>();
    public  ICollection<TIntFinancement> IntFinancements{ get; }= new List<TIntFinancement>();
    public  ICollection<TMvtCredit> MvtCredits{ get; }= new List<TMvtCredit>();
    public  ICollection<TBordereau> Bordereaus{ get; }= new List<TBordereau>();
    public  ICollection<TCalcInt> CalcInts{ get; }= new List<TCalcInt>();
    public  ICollection<TEcCpt> EcCpts{ get; }= new List<TEcCpt>();
    public  ICollection<TEtatDispo> EtatDispos{ get; }= new List<TEtatDispo>();
    public  ICollection<TCalcDispo> CalcDispos{ get; }= new List<TCalcDispo>();
    public  ICollection<TCalcIntIR> CalcIntIrs{ get; }= new List<TCalcIntIR>();
    public  ICollection<TFinancement> Financements{ get; }= new List<TFinancement>();
    public  ICollection<TFraisPaiment> FraisPaiments{ get; }= new List<TFraisPaiment>();
    public  ICollection<TComFactoring> ComFactorings{ get; }= new List<TComFactoring>();


  
    


}