using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllAdherents;

public record GetAllAdherentsQuery : IRequest<OperationResult<List<AdherentDto>>>;