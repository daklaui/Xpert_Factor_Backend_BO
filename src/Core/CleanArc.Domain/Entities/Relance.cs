using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRelance :BaseEntity,IEntity
{
    public string RefCtrRelance { get; set; }
    public string LibelleRelance { get; set; }
    public Nullable<System.DateTime> DateRelance { get; set; }
    public string RefDocRelance { get; set; }
    public byte ValidRelance { get; set; }
    public string UserRelance { get; set; }

    public int idContrat { get; set; } 
    public TContrat Contrat { get; set; } = null!;
}