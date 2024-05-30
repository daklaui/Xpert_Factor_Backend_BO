using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.buyer.Commands.Queries;

public record GetAcheteursByContratQuery(int RefCtrCir) : IRequest<OperationResult<List<AcheteurDto>>>;
