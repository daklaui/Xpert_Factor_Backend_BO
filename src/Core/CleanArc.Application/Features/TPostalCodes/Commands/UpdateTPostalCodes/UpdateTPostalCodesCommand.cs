

using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TPostalCodes.Commands
{
    public class UpdateTPostalCodesCommand : IRequest<OperationResult<Unit>>
    {
        public int Id { get; set; }
        public string CodeGouvernorat { get; set; }
        public string CodeRegion { get; set; }
        public string D_Cp { get; set; }
        public string Gouvernorat { get; set; }
        public string Region { get; set; }
        public string Ville { get; set; }
    }
}
