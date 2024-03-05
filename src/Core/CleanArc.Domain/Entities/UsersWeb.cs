using CleanArc.Domain.Common;
namespace CleanArc.Domain.Entities;

public class TUsersWeb : BaseEntity,IEntity
{
    public int RefIndWeb { get; set; }
    public string LoginWeb { get; set; }
    public string PasswordWeb { get; set; }
    public string LogoWeb { get; set; }
    public bool ActifUserWeb { get; set; }
    public Nullable<System.DateTime> DateFinCompte { get; set; }
    public string OneSignalPlayerId { get; set; }
    
    public int idIndividu { get; set; } 
    public TIndividu Individu { get; set; } = null!;
    
}