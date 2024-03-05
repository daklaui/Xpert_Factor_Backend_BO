using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRListFraisDivers:BaseEntity,IEntity
{
    public char  AbrevFraisDiv{ get; set; }
    public char  LibFraisDivers{ get; set; }
    public decimal MontFraisDive{ get; set; }
    public char  TypeFraisDiver{ get; set; }
    public int idFactor { get; set; }
    public  TFactor Factor { get; set; }= null!;

}