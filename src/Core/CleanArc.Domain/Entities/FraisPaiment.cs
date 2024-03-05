using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFraisPaiment:BaseEntity,IEntity
{
    
    public char TypFraisPaie { get; set; }
    public int RefCtrFraisPaie { get; set; }
    public decimal MontParInstrFraisPaie { get; set; }
    public string  LibFraisPaie { get; set; }

    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;




    
}