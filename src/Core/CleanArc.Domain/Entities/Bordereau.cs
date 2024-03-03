using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TBordereau :BaseEntity,IEntity
{
    public string NumBord { get; set; }
    public int RefCtrBo { get; set; }
    public char AnneeBord { get; set; }
    public int RefAdhBo { get; set; }
    public int RefAchBo { get; set; }
    public Nullable<System.DateTime> DatBord { get; set; }
    public short NbDocBor { get; set; }
    public decimal MontTotB { get; set; }
    public string DeviseAch { get; set; }
    public bool SoldeBord { get; set; }
    public bool ValideBor { get; set; }
    public Nullable<System.DateTime> DatSaisie { get; set; }
    public string Emetteur { get; set; }
    public virtual ICollection<TContrat> Contrats{ get; set; }

}