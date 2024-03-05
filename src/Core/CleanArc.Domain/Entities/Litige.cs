using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TLitige :BaseEntity,IEntity
{
    public char TypLit{ get; set; }
    public int RefCtrLit{ get; set; }
    public Nullable<System.DateTime> DateLit { get; set; }
    public Nullable<System.DateTime> EchLit { get; set; }
    public decimal MontLt{ get; set; }
    public byte EtatLit{ get; set; }
    public int IdDetBordLit{ get; set; }

    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;

    

}