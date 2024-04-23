using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;

public class RejectFinanceCommand :IRequest<OperationResult<Unit>>
{
    public int ID_FIN { get; set; }
    public string ETAT_FIN { get; set; } 
}