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
    public int TContratRefCtr { get; set; }
    public TComMfg ComMfg { get; set; }
    public TPropagation Propagation { get; set; }
    public TEncaissement  Encaissement { get; set; }
}