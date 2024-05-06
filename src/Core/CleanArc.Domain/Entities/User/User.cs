using CleanArc.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArc.Domain.Entities.User;

public class User:IdentityUser<int>,IEntity
{
    public User()
    {
        this.GeneratedCode = Guid.NewGuid().ToString().Substring(0, 8);
    }

    public int ID_USER { get; set; }

    public int ID_GRP_USER { get; set; }

    public string NOM_USER { get; set; }

    public string PRE_USER { get; set; }

    public string LOGIN_USER { get; set; }

    public string MDP_USER { get; set; }

    public bool ACTIF_USER { get; set; }

    public string FONCTION_USER { get; set; }

    public string SERVICE_USER { get; set; }

    public string DIRECTION_USER { get; set; }

    public string AGENCE_USER { get; set; }

    public string MAIL_USER { get; set; }

    public string TEL_FIXE_USER { get; set; }

    public string MOBILE_USER { get; set; }

    public string PHOTO_USER { get; set; }

    public string ONE_SIGNAL_PLAYER_ID { get; set; }

    //public virtual TS_GRP_USER ID_GRP_USERNavigation { get; set; }
    public string GeneratedCode { get; set; }
       
    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<UserLogin> Logins { get; set; }
    public ICollection<UserClaim> Claims { get; set; }
    public ICollection<UserToken> Tokens { get; set; }
    public ICollection<UserRefreshToken> UserRefreshTokens { get; set; }

    #region Navigation Properties

    public IList<Order.Order> Orders { get; set; }

    #endregion

}