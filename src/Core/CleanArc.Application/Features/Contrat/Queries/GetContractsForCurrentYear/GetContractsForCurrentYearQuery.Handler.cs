using CleanArc.Application.Contracts.Persistence;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Queries
{
    public class GetContractsForCurrentYearQueryHandler : IRequestHandler<GetContractsForCurrentYearQuery, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetContractsForCurrentYearQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async ValueTask<int> Handle(GetContractsForCurrentYearQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.ContratRepository.GetContractsForCurrentYearasync();
        }
    }
}