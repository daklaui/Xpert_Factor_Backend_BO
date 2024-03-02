using System.ComponentModel.DataAnnotations.Schema;
using CleanArc.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.Entities;

public class TGrpUser:BaseEntity,IEntity
{   
    public int IdGrpUser { get; set; }
    public string LibGrpUser{ get; set; }
    public byte ActifGrpUser{ get; set; }

    public virtual ICollection<TGroupe> Groupe { get; set; }

}