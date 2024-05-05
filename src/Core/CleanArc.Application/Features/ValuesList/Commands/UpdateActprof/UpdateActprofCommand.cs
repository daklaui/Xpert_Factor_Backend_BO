using CleanArc.Application.Models.Common;
using Mediator;
namespace CleanArc.Application.Features.ValuesList.Commands.UpdateActprof;

public class UpdateActprofCommand : IRequest<OperationResult<Unit>>
{
    public string Code_Section { get; set; }

    public string Section { get; set; }

    public string Code_SousSection { get; set; }

    public string SousSection { get; set; }

    public string Code_Activité { get; set; }

    public string Code_Classe { get; set; }

    public string Classe { get; set; }

    public string Code_Classe1 { get; set; }

    public string Code_SousClasse { get; set; }

    public string SousClasse { get; set; }
}