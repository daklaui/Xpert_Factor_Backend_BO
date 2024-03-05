using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TAdresse :BaseEntity,IEntity
{
    
    public string LibAdr { get; set; }
    public string CpAdr { get; set; }
    public int IdLocA { get; set; }
    public int IdDele { get; set; }
    public int IdGouv { get; set; }
    public int IdNldp { get; set; }
    public bool ActifAd { get; set; }
    
    public int idTIndividu { get; set; }
    public TIndividu Individu { get; set; } = null!;

}