using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TJCir :BaseEntity,IEntity
{
    public int RefCtrCir { get; set; }
    public int RefIndCir { get; set; }
    public int IdRoleCir { get; set; }
    
    
    public int idIndividu { get; set; } 
    public TIndividu Individu { get; set; } = null!;
    
    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
    
    public int idTRole { get; set; } 
    public TRole Role { get; set; } = null!;
    


}