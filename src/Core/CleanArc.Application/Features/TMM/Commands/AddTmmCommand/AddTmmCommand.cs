using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;


namespace CleanArc.Application.Features.TMM.Commands.AddTmmCommand;

public record  AddTmmCommand(TRTMM Trtmm) : IRequest<OperationResult<bool>>;
