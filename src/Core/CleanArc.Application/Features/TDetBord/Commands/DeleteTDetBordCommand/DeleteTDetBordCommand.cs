using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Commands.DeleteTDetBordCommand;

public class DeleteTDetBordCommand : IRequest<OperationResult<bool>>
{
    public string TDetBordId { get; set; }
}