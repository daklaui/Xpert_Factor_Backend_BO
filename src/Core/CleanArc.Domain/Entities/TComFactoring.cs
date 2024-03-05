using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TComFactoring:BaseEntity,IEntity
{
    public char  TypCommFactoring{ get; set; }
    public char  TxCommFactoring{ get; set; }
    public decimal MontMinDocCommFactoring{ get; set; }
    public decimal MontMinCtrCommFactoring{ get; set; }
    public int RefCtrCommFactoring{ get; set; }
   
    
    public  ICollection<TFraisDivers> FraisDiversCollection{ get; }= new List<TFraisDivers>();
    public  ICollection<TContact> Contacts{ get; }= new List<TContact>();

}