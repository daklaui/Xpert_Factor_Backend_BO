using CleanArc.Application.Models.Common;
using MediatR;

namespace CleanArc.Application.Features.Profil.Commands.UpdateProfilCommand;


public record UpdateProfilCommand(Domain.Entities.Profil profil,int idProfil):IRequest<OperationResult<bool>>;