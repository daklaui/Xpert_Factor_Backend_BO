using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TR_LIST_VAL : BaseEntity
{
    public int Id { get; set; }
    public string AbrListVal { get; set; }
    public string TypListVal { get; set; }
    public short? OrdListVal { get; set; }
    public string LibListVal { get; set; }
    public string ComListVal { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime? ModifiedDate { get; set; }
}