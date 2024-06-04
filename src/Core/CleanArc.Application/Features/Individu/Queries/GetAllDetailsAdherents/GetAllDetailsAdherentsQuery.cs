using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllDetailsAdherents;

public record GetAllDetailsAdherentsQuery (int refCTR) :  IRequest<OperationResult<List<AdherentDetailDto>>>;
