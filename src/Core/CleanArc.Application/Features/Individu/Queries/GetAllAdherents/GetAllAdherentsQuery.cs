using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllAdherents;

public record GetAllAdherentsQuery : IRequest<OperationResult<List<string>>>;