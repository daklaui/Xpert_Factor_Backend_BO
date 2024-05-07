namespace CleanArc.Domain.Entities.User;

public class UserROLES
{
    public int UserId { get; set; }
    public TS_USER User { get; set; }

    public int RoleId { get; set; }
    public Role Role { get; set; }
}