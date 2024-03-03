using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TJCir :BaseEntity,IEntity
{
    public int IdCir { get; set; }
    public int RefCtrCir { get; set; }
    public int RefIndCir { get; set; }
    public int IdRoleCir { get; set; }
    public virtual ICollection<TContrat> Contrats{ get; set; }
    public virtual ICollection<TIndividu> Individus{ get; set; }
    public virtual ICollection<TRole> Roles{ get; set; }

    


}