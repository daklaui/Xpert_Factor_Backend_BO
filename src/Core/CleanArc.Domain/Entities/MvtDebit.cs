using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TMvtDebit:BaseEntity,IEntity
{
    public int RefCtrDebit { get; set; }
    public string AbevDebit { get; set; }
    public char TypDebit { get; set; }
    public decimal MontDebit { get; set; }
    public Nullable<System.DateTime> DateDebit { get; set; }
    public virtual ICollection<TContrat> Contrats{ get; set; }





    
}