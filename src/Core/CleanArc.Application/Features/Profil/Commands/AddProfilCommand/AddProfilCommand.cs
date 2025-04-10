using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Profil.Commands;

public record AddProfilCommand(Domain.Entities.Profil profil):IRequest<OperationResult<bool>>;