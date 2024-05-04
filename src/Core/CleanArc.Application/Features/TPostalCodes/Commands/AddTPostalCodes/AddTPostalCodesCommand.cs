

using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TPostalCodes.Commands
{
    public record AddTPostalCodesCommand(Domain.Entities.TPostalCodes TPostalCodes) : IRequest<OperationResult<bool>>;
}
