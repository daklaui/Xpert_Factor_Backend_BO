using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Commands.UpdatePostalCodeCommand;

public record UpdatePostalCodeCommand(int id, TR_CP Cp) : IRequest<OperationResult<bool>>;
