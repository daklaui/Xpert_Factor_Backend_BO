using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.FactoringCommission.Queries.GetAllFactoringCommissions
{
    internal class GetAllFactoringCommissionsQueryHandler : IRequestHandler<GetAllFactoringCommissionsQuery, OperationResult<PageInfo<GetAllFactoringCommissionsQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllFactoringCommissionsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllFactoringCommissionsQueryResult>>> Handle(GetAllFactoringCommissionsQuery request, CancellationToken cancellationToken)
        {
            var commissions = await _unitOfWork.FactoringCommissionRepository.GetAllFactoringCommissionsAsync(request.paginationParams);

            var result = new PageInfo<GetAllFactoringCommissionsQueryResult>
            {
                PageSize = commissions.PageSize,
                CurrentPage = commissions.CurrentPage,
                TotalPages = commissions.TotalPages,
                TotalCount = commissions.TotalCount,
                Result = commissions.Select(_mapper.Map<T_COMM_FACTORING, GetAllFactoringCommissionsQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllFactoringCommissionsQueryResult>>.SuccessResult(result);
        }
    }
}