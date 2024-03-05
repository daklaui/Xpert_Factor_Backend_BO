using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TEcCpt:BaseEntity,IEntity
{
    public int AnneeEcCpt { get; set; }
    public string CodeDepEcCpt { get; set; }
    public string NumEcEcCpt { get; set; }
    public int NumLigneEcCpt { get; set; }
    public string CodeJournalEcCpt { get; set; }
    public  Nullable<System.DateTime> DateSaisieEcCpt { get; set; }
    public  Nullable<System.DateTime> DateEffetEcCpt { get; set; }
    public string LibelleeEcCpt { get; set; }
    public string CompteGenEcCpt { get; set; }
    public decimal MontantEcCpt { get; set; }
    public string CodeCentreAnalyse { get; set; }
    public string RefPieceEcCpt { get; set; }
    public string TypeTransactionEcC { get; set; }
    public string TypeDocEcCpt { get; set; }
    public string NomUserEcCpt { get; set; }
    public string LotEcCpt { get; set; }
    public string CodeTiersEcCpt { get; set; }
    public string DomaineEcCpt { get; set; }
    public decimal CreditEcCpt { get; set; }
    public  Nullable<System.DateTime> DateEcCpt { get; set; }
    public int RefAdhEcCpt { get; set; }
    public string CompteEcCpt { get; set; }
    public string CodeEcCpt { get; set; }
    public string IntituleEcCpt { get; set; }
    public string RefMfgAdhEcCpt { get; set; }
    
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
}