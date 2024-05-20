using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;


namespace CleanArc.Application.Features.Litige.Commands.Add;

public record AddCommand(T_LITIGE litige) : IRequest<OperationResult<bool>>;
