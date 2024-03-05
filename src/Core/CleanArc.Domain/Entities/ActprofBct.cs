using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRActprofBct:BaseEntity,IEntity
{
    public char  codeSection{ get; set; }
    public char  Section{ get; set; }
    public char  CodeSousSection{ get; set; }
    public char  SousSection{ get; set; }
    public char  CodeActivite{ get; set; }
    public char  CodeClasse{ get; set; }
    public char  Classe{ get; set; }
    public char  CodeClasse1{ get; set; }
    public char  CodeSousClasse{ get; set; }
    public char  SousClasse{ get; set; }
    
    public int idFactor { get; set; }
    public  TFactor Factor { get; set; }= null!;
}