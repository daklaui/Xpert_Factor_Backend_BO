using CleanArc.Application.Contracts.Persistence;
 
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllIndividus
{
    internal class GetAllIndividusQueryHandler : IRequestHandler<GetAllIndividusQuery,OperationResult<List<GetAllIndividusQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllIndividusQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<List<GetAllIndividusQueryResult>>> Handle(GetAllIndividusQuery request, CancellationToken cancellationToken)
        {
 
            return OperationResult<List<GetAllIndividusQueryResult>>.SuccessResult(null);
        }
    }
}
