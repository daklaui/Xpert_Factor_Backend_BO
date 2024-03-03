using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TUser :BaseEntity,IEntity
{
    public int IdUser { get; set; }
    public int IdGrpUser { get; set; }
    public string NomUser { get; set; }
    public string PreUser { get; set; }
    public string LoginUser { get; set; }
    public string MdpUser { get; set; }
    public bool ActifUser { get; set; }
    public string FonctionUser { get; set; }
    public string ServiceUser { get; set; }
    public string DirectionUser { get; set; }
    public string AgenceUser { get; set; }
    public string MailUser { get; set; }
    public string TelFixeUser { get; set; }
    public string MobileUser { get; set; }
    public string PhotoUser { get; set; }
    public string OneSignalPlayerId { get; set; }
    public int TsGrpUserIdGrpUs { get; set; }
    public virtual ICollection<TSGrpUser> TsGrpUsers { get; set; }
    public virtual ICollection<TFactor> Factors { get; set; }

    
}