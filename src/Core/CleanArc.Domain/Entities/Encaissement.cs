using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TEncaissement :BaseEntity,IEntity
{
    public int RefCtrEnc { get; set; }
    public int RefAdhEnc { get; set; }
    public int RefAchEnc { get; set; }
    public decimal MontEnc { get; set; }
    public string DeviseEnc { get; set; }
    public  Nullable<System.DateTime> DatRecepEnc { get; set; }
    public  Nullable<System.DateTime> DatValEnc { get; set; }
    public string TypEnc { get; set; }
    public bool ValideEnc { get; set; }
    public string RefEnc { get; set; }
    public string RibEnc { get; set; }
    public string BordEnc { get; set; }
    public string RefSeqEnc { get; set; }
    public bool Preavis { get; set; }
    
    public int idIndividu { get; set; } 
    public TIndividu Individu { get; set; } = null!;
    
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
    
    public  ICollection<TJLettrage> Lettrages { get; }= new List<TJLettrage>();

}