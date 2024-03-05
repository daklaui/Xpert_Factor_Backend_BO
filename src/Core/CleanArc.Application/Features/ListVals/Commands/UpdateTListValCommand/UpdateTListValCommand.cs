using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;

public class UpdateTListValCommand : IRequest<OperationResult<Unit>> 
{
        public int Id { get; set; }
        public string AbrListVal { get; set; }
        public string TypListVal { get; set; }
        public short? OrdListVal { get; set; }
        public string LibListVal { get; set; }
        public string ComListVal { get; set; }
}
    

 
