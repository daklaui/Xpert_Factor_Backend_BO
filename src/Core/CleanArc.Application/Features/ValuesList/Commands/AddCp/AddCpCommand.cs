using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Commands.AddCp;

public record AddCpCommand(TR_CP cp) : IRequest<OperationResult<bool>>;

