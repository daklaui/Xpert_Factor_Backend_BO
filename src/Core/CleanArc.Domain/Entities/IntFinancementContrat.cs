using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TIntFinancement :BaseEntity,IEntity
{
    public int  RefCtrIntFin { get; set; }
    public char  TypInstrIntFin{ get; set; }
    public decimal  TxIntMarcheIntFin{ get; set; }
    public decimal   TxMargeCtrIntFin{ get; set; }
    public int DelaiMaxPaiIntFin { get; set; }
    public decimal  PreCompteIntFin{ get; set; }
    public decimal  MajorIntIntFin{ get; set; }
    public Nullable<System.DateTime>  DatDebValidIntF{ get; set; }

    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
    
}