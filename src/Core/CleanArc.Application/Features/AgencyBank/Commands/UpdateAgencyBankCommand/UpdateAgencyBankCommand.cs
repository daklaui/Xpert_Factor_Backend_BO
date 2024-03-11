using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Commands.UpdateAgencyBankCommand;


public record UpdateAgencyBankCommand(string Code_Bq_Ag, string Code_Bq , string Banque, string Code_Ag, string Agence) : IRequest<OperationResult<bool>>;
