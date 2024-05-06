using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;

public class ValidateLimiteCommand:IRequest<OperationResult<bool>>
{
    public int REF_DEM_LIM { get; set; }
    public string DECISION_LIM { get; set; }
    public bool? ACTIF_DEM_LIMI { get; set; }
    
}