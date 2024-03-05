using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRIntFinancement:BaseEntity,IEntity
{
    public char  TypInstrIntFin{ get; set; }
    public decimal  TxIntMarcheIntF{ get; set; }
    public decimal   TxMargeCtrIntFi{ get; set; }
   public int DelaiMaxPaiIntFi { get; set; }
   public decimal  PreCompteIntFin{ get; set; }
   public Nullable<System.DateTime>  DatDebValidIntF{ get; set; }
   
   public int idFactor { get; set; }
   public  TFactor Factor { get; set; }= null!;
  

}