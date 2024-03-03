using System.ComponentModel.DataAnnotations;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRCp:BaseEntity,IEntity
{
    public char Cp { get; set; }
    public char Ville { get; set; }
    public char CodeGouverno { get; set; }
    public char CodeRegion { get; set; }
    public char Region { get; set; }
    [Key]
    public int IdCp { get; set; }
    public virtual ICollection<TFactor> Factors { get; set; }

}