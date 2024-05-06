using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities.User;

public class ROLES : IEntity
{
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}