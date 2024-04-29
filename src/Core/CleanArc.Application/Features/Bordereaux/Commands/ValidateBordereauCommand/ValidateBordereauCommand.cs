using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.ValidateBordereauCommand;

public record ValidateBordereauCommand : IRequest<bool>
{
    public PksBordereauxDto PksBordereauxDto { get; init; }

    public ValidateBordereauCommand(PksBordereauxDto pksBordereauxDto)
    {
        PksBordereauxDto = pksBordereauxDto;
    }
}