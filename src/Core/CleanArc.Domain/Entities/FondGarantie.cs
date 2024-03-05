using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFondGarantie :BaseEntity,IEntity
{
    public string TypFdg { get; set; }
    public int RefCtrFdg { get; set; }
    public string LibFdg { get; set; }
    public decimal TxFdg { get; set; }
    public decimal MontMaxFdg { get; set; }
    public decimal MontMinFdg { get; set; }
    public string TypDocRemisFdg { get; set; }

    
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
}