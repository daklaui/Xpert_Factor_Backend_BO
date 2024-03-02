using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TGroupe :BaseEntity,IEntity
{
    public string NomGro { get; set; }
    public TGrpUser TGrpUser {get; set; }
    public int TGrpUserId { get; set; } // Clé étrangère vers TGrpUser
    
}