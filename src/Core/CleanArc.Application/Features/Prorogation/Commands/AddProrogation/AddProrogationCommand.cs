using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Prorogation.Commands.AddProrogation;

public record AddProrogationCommand
    (T_PROROGATION Prorogation, DateTime EcheanceFacturePro) : IRequest<OperationResult<bool>>;
