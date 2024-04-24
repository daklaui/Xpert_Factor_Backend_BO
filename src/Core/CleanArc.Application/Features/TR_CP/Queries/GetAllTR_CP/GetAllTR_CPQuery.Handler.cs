using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using Mediator;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.TR_CP.Queries.GetAllTR_CP
{
    internal class GetAllTR_CPQueryHandler : IRequestHandler<GetAllTR_CPQuery, OperationResult<PageInfo<GetAllTR_CPQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTR_CPQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllTR_CPQueryResult>>> Handle(GetAllTR_CPQuery request, CancellationToken cancellationToken)
        {
            var tr_cps = await _unitOfWork.TR_CPRepository.GetAllTR_CPsAsync(request.paginationParams);

            var result = new PageInfo<GetAllTR_CPQueryResult>
            {
                PageSize = tr_cps.PageSize,
                CurrentPage = tr_cps.CurrentPage,
                TotalPages = tr_cps.TotalPages,
                TotalCount = tr_cps.TotalCount,
                Result = tr_cps.Select(_mapper.Map<Domain.Entities.TR_CP, GetAllTR_CPQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllTR_CPQueryResult>>.SuccessResult(result);
        }
    }
}