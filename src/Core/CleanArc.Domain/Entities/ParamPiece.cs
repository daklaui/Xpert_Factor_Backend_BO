using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRParamPiece:BaseEntity,IEntity
{
    public string LibParamPie { get; set; }
    public char TypParamPie { get; set; }
    public char SignParamPi { get; set; }
    
    public int idFactor { get; set; }
    public  TFactor Factor { get; set; }= null!;
    
}