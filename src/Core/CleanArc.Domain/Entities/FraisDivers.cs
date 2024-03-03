using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFraisDivers:BaseEntity,IEntity
{
    public char TypFraisDivers { get; set; }
    public int RefCtrFraisDivers { get; set; }
    public string  LibFraisDivers { get; set; }
    public decimal MontParInstrFraisDivers { get; set; }
    public TContrat Contrat { get; set; }
}