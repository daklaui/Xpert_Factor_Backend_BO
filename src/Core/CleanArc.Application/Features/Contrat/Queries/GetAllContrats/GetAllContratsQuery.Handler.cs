using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using Mediator;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.Contrat.Queries.GetAllContrats
{
    internal class GetAllContratsQueryHandler : IRequestHandler<GetAllContratsQuery, OperationResult<PageInfo<GetAllContratsQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllContratsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllContratsQueryResult>>> Handle(GetAllContratsQuery request, CancellationToken cancellationToken)
        {
            var contrats = await _unitOfWork.ContratRepository.GetAllContratsAsync(request.paginationParams);

            var result = new PageInfo<GetAllContratsQueryResult>
            {
                PageSize = contrats.PageSize,
                CurrentPage = contrats.CurrentPage,
                TotalPages = contrats.TotalPages,
                TotalCount = contrats.TotalCount,
                Result = contrats.Select(_mapper.Map<T_CONTRAT, GetAllContratsQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllContratsQueryResult>>.SuccessResult(result);
        }
    }
}
