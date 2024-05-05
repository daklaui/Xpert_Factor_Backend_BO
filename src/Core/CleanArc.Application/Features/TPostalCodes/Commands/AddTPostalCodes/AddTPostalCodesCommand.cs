

using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TPostalCodes.Commands
{
    public record AddTPostalCodesCommand(Domain.Entities.TR_CP trCp) : IRequest<OperationResult<bool>>;
}
