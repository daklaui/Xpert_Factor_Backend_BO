using CleanArc.Application.Profiles;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetById;

public record GetByIdQueryResult
{
    public BordereauDTO Bordereau { get; set; }
}