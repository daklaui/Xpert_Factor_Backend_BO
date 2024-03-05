using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TDocGed:BaseEntity,IEntity
{
    public int IdCtrGed { get; set; }
    public int IdBorGed { get; set; }
    public int IdDetBordGed { get; set; }
    public int IdEncGed { get; set; }
    public int IdDebitGed { get; set; }
    public int IdCreditGed { get; set; }
    public int IdFinancementGed { get; set; }
    public int IdAnneeBordGed { get; set; }
    public string LibelleGed { get; set; }
    public Nullable<System.DateTime> DateTacheGed { get; set; }
    public int IdGestionnaireGed { get; set; }
    public Nullable<System.DateTime> DateScanGed { get; set; }
    public string AdressDocGed { get; set; }
    public string DataGed { get; set; }
    public string NameGed { get; set; }
    public string SalleGed { get; set; }
    public string AemoireGed { get; set; }
    public string EtgageGed { get; set; }
    public string ArchiveGed { get; set; }
    public string Libelle2Ged { get; set; }
    public string IdEmetteurGed { get; set; }
    public string EtapeGed { get; set; }
    public byte EtatGed { get; set; }

    public int idFinancement { get; set; } 
    public TFinancement Financement { get; set; } = null!;

    public  ICollection<TDetBord>  DetBords{ get; }= new List<TDetBord>();




    
}