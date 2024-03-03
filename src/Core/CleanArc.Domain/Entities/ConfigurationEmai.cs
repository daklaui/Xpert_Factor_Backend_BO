using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TConfigurationEmai:BaseEntity,IEntity
{
    public int IdFa { get; set; }
    public string Email { get; set; }
    public string Mdp { get; set; }
    public string Smtp { get; set; }
    public int Port { get; set; }
    public int Enabl { get; set; }
    public int Id { get; set; }



    
}