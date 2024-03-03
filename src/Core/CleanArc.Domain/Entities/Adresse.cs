using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TAdresse :BaseEntity,IEntity
{
    public int IdAdr { get; set; }
    public int RefInd { get; set; }
    public string LibAdr { get; set; }
    public string CpAdr { get; set; }
    public int IdLocA { get; set; }
    public int IdDele { get; set; }
    public int IdGouv { get; set; }
    public int IdNldp { get; set; }
    public bool ActifAd { get; set; }
    public virtual ICollection<TIndividu> Individus{ get; set; }

}