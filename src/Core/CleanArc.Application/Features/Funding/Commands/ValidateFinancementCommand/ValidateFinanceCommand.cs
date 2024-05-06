using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand;

public class ValidateFinanceCommand : IRequest<OperationResult<bool>>
{
    public int ID_FIN { get; set; }
    public string ETAT_FIN { get; set; }
}