using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TMM.Commands.UpdateTmmCommand;

public record UpdateTmmCommand(DateTime DATE_DEBUT_TMM,DateTime  DATE_FIN_TMM, decimal TAUX_TMM, int  ID_TMM): IRequest<OperationResult<bool>>;
