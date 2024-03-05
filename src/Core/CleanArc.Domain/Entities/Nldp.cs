using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TRNldp :BaseEntity,IEntity
{
    public string LibNt { get; set; }
    public char AbrvN { get; set; }
    public string LibLan { get; set; }
    public char AbrvLa { get; set; }
    public string LibDevi { get; set; }
    public char AbrvD { get; set; }
    public string LibPays { get; set; }
    public char AbrvPa { get; set; }

    public int idFactor { get; set; }
    public  TFactor Factor { get; set; }= null!;
}