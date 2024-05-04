using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;
namespace CleanArc.Application.Features.Financement.Queries
{
    internal class GetAllFinancementQueryHandler : IRequestHandler<GetAllFinancementQuery, OperationResult<PageInfo<GetAllFinancementQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllFinancementQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllFinancementQueryResult>>> Handle(GetAllFinancementQuery request, CancellationToken cancellationToken)
        {
            var financement = await _unitOfWork.FundingRepository.GetAllFinancementAsync(request.paginationParams);

            var result = new PageInfo<GetAllFinancementQueryResult>
            {
                PageSize = financement.PageSize,
                CurrentPage = financement.CurrentPage,
                TotalPages = financement.TotalPages,
                TotalCount = financement.TotalCount,
                Result = financement.Select(_mapper.Map<T_FINANCEMENT, GetAllFinancementQueryResult>).ToList()

            };
            return OperationResult<PageInfo<GetAllFinancementQueryResult>>.SuccessResult(result);
        }
    }
}