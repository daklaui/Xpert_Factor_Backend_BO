using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TPropagation:BaseEntity,IEntity
{
    public int RefCtrProg { get; set; }
    public string TypProg { get; set; }
    public string MotifProg { get; set; }
    public  Nullable<System.DateTime> DatProg { get; set; }
    public  Nullable<System.DateTime> EchProg { get; set; }
    public bool EtatProg { get; set; }
    public int IdDetBordPr { get; set; }
    public int IdProrogation { get; set; }
    public int TContratRef { get; set; }
    public virtual ICollection<TFondGarantie> FondGaranties { get; set; }
    public virtual ICollection<TDetBord> DetBords { get; set; }


}