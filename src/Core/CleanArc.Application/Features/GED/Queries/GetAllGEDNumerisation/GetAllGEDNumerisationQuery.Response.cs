using CleanArc.Application.Profiles;
using CleanArc.Domain.DTO;

namespace CleanArc.Application.Features.GED.Queries;

public record GetAllGEDNumerisationQueryResult : ICreateMapper<GEDNumerisationDTO>
{
    public int id  { get; set; }
    public int ID_IND_GED { get; set; }
    public string LIBELLE2_GED { get; set; }
    public string LIBELLE_GED { get; set; }
    public DateTime DATE_TACHE_GED { get; set; }
    public string NOM_IND { get; set; }
    public DateTime Expr1  { get; set; }
    public string Expr2 { get; set; }
    public DateTime Date_Ech { get; set; }
    public string Expr3 { get; set; }
    public int R { get; set; }
    public int P { get; set; }
    public int E { get; set; }
    public string Etape_GED { get; set; }
    public int ID_CTR_GED { get; set; }
}