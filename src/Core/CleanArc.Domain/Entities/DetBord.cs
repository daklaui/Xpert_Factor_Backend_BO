using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TDetBord :BaseEntity,IEntity
{
    public string AnneeBord { get; set; }
    public string NumBord { get; set; }
    public string TypDetBord { get; set; }
    public string NumCreanceAssBord { get; set; }
    public string TypAssDetBord { get; set; }
    public Nullable<System.DateTime> DatDetBord { get; set; }
    public decimal MontTtcDetBord { get; set; }
    public string DeviseDetBord { get; set; }
    public short EchDetBord { get; set; }
    public Nullable<System.DateTime> EchAprProrogDetBord { get; set; }
    public decimal MontOuvDetBord { get; set; }
    public short DelaiPaieDetBord { get; set; }
    public string ModeRegDetBord { get; set; }
    public string TypRegDetBord { get; set; }
    public decimal TxFdgDetBord { get; set; }
    public decimal TxCommFactDetBord { get; set; }
    public bool AnnulDetBord { get; set; }
    public bool ValideDetBord { get; set; }
    public int RefIndDetBord { get; set; }
    public decimal MontFdgDetBord { get; set; }
    public decimal MontFdgLibereDetBord { get; set; }
    public decimal MontCommFactDetBord { get; set; }
    public decimal TxTvaCommFactDetBord { get; set; }
    public decimal MontTvaCommFactDetBor { get; set; }
    public decimal MontTtcCommFactDetBor { get; set; }
    public int IdCalcDispoDetBord { get; set; }
    public string RefDetBord { get; set; }
    public string CommDetBord { get; set; }
    public string RetenuDetBord { get; set; }
    
    public virtual ICollection<TPropagation> Propagations{ get; set; }
    public virtual ICollection<TJLettrage> JLettrage{ get; set; }

    public int ILitige { get; set; } 
    public TLitige Litige { get; set; } = null!;
    public int idDocGed { get; set; } 
    public TDocGed DocGed { get; set; } = null!;
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
    public int idBordereau { get; set; } 
    public TBordereau Bordereau { get; set; } = null!;
}