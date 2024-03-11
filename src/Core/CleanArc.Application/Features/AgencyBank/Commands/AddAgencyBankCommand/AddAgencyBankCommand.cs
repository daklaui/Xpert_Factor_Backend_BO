using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Commands.AddAgencyBankCommand;

public record AddAgencyBankCommand(TR_Ag_Bq AgBq) : IRequest<OperationResult<bool>>;
