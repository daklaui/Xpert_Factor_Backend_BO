using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities.User;

public class Permission : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}