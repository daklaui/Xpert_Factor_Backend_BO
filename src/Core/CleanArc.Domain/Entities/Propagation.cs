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
   

    
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
    
    public int idDetBord { get; set; } 
    public TDetBord DetBord { get; set; } = null!;

}