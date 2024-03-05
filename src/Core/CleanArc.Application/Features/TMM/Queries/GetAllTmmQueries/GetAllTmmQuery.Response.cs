using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TMM.Queries.GetAllTmmQueries;
public record GetAllTmmQueryResult:ICreateMapper<TRTMM>
{
    public Nullable<System.DateTime> StartDateTMM { get; set; }
    public Nullable<System.DateTime> EndDateTMM { get; set; }
    public string RateTMM { get; set; }
}