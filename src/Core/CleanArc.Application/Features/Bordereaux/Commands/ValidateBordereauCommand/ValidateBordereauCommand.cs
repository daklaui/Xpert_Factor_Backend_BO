using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.ValidateBordereauCommand;

public record ValidateBordereauCommand(PksBordereauxDto PksBordereauxDto) : IRequest<bool>;
