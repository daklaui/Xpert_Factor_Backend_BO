using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.RIB.Commands.EditRibIndividuCommand;

public class EditRibIndividuCommand : IRequest<OperationResult<Unit>>
{
    public string RIB_RIB1 { get; set; }
    
    public string RIB_RIB2 { get; set; }

    public string RIB_RIB3 { get; set; }
    
    public int REF_IND_RIB { get; set; }

    public bool? ACTIF_RIB { get; set; }
    
    public string OLD_RIB_RIB { get; set; }
}
