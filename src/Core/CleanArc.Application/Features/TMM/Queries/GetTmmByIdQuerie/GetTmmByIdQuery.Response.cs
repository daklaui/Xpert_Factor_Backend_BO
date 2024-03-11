using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TMM.Queries.GetTmmByIdQuerie;


public class GetTmmByIdQueryResult : ICreateMapper<TR_TMM>
{
    public DateTime? DATE_DEBUT_TMM { get; set; }

    public DateTime? DATE_FIN_TMM { get; set; }

    public decimal? TAUX_TMM { get; set; }

    public int ID_TMM { get; set; }

}