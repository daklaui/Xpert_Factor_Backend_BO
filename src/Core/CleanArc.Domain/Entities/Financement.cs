using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFinancement:BaseEntity,IEntity
{
    public int RefCtrF { get; set; }
    public decimal MontFin { get; set; }
    public Nullable<System.DateTime> DatFin { get; set; }
    public string InstrFin { get; set; }
    public string RefInstr { get; set; }
    public Nullable<System.DateTime> DatInstr { get; set; }
    public string EtatFin { get; set; }
    public int IdDispo { get; set; }
    public string TypeEnc { get; set; }
    public virtual ICollection<TContrat> Contrats{ get; set; }


    
}