using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFraisReleve:BaseEntity,IEntity
{
    public int IdFraisRel { get; set; }
    public int RefCtr { get; set; }
    public Nullable<System.DateTime> datRecepEnc { get; set; }
    public string TypEnc { get; set; }
    public string NbPiece { get; set; }
    public decimal MontParInstrFraisPaie { get; set; }
    public decimal TVA{ get; set; }
    public decimal TaxTva { get; set; }
    public decimal TTCPP{ get; set; }
    public decimal MNTTCT { get; set; }
    public virtual ICollection<TContrat> Contrats{ get; set; }


}