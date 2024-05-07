using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Queries.DetailsDetBord;

public record GetDetailsDetBordQuery(PksDetBordDto PksDto) : IRequest<OperationResult<GetDetailsDetBordQueryResult>>;