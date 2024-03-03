using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRListVal :BaseEntity,IEntity
{
    public char AprListVal { get; set; }
    public char TypListVal { get; set; }
    public int OrdListVal { get; set; }
    public string LibListVal { get; set; }
    public string ComListVal { get; set; }
    public int NbJourListVal { get; set; }
    public string TypeRecouvreme { get; set; }
    
}