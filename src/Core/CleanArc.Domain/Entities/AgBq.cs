using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRAgBq:BaseEntity,IEntity
{
    public char  CodeBqAg{ get; set; }
    public char  CodeAg{ get; set; }
    public char  CodeBq{ get; set; }
    public char  Agence{ get; set; }
    public char  Banque{ get; set; }
    public virtual ICollection<TFactor> Factors { get; set; }





}