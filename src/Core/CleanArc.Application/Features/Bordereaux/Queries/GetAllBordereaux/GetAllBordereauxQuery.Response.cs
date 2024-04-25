using CleanArc.Application.Profiles;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetAllBordereaux;

public record GetAllBordereauxQueryResult 
{
    public BordereauDTO Bordereau { get; set; }
}