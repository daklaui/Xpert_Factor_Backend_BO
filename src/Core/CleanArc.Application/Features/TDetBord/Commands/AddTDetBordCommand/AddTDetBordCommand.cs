using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Commands.AddTDetBordCommand;

public record AddTDetBordCommand(T_DET_BORD DetBord): IRequest<OperationResult<bool>>;