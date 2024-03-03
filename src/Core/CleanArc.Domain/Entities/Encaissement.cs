using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TEncaissement :BaseEntity,IEntity
{
    public int IdEnc { get; set; }
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
    public virtual ICollection<TIndividu> Individus { get; set; }
    public virtual ICollection<TFondGarantie> FondGaranties { get; set; }
    public TJLettrage Lettrage { get; set; }

}