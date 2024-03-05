using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TMvtCredit :BaseEntity,IEntity 
{
    public int RefCtrCerdit{ get; set; }
    public string AvrvCerdit{ get; set; }
    public char TypCredit { get; set; }
    public decimal MontCredit { get; set; }
    public string RefEncCredit { get; set; }
    public string LibelleLibreCredit { get; set; }
    public Nullable<System.DateTime> DateValEncCredit { get; set; }
    public Nullable<System.DateTime> DateCredit { get; set; }

    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;

}