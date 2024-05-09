using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.FraisDivers.Queries.GetAllFraisDivers
{
    internal class GetAllFraisDiversQueryHandler : IRequestHandler<GetAllFraisDiversQuery, OperationResult<PageInfo<GetAllFraisDiversQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllFraisDiversQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllFraisDiversQueryResult>>> Handle(GetAllFraisDiversQuery request, CancellationToken cancellationToken)
        {
            var fraisDivers = await _unitOfWork.FraisDiversRepository.GetAllFraisDiversAsync(request.paginationParams);

            var result = new PageInfo<GetAllFraisDiversQueryResult>
            {
                PageSize = fraisDivers.PageSize,
                CurrentPage = fraisDivers.CurrentPage,
                TotalPages = fraisDivers.TotalPages,
                TotalCount = fraisDivers.TotalCount,
                Result = fraisDivers.Select(_mapper.Map<T_FRAIS_DIVER, GetAllFraisDiversQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllFraisDiversQueryResult>>.SuccessResult(result);
        }
    }
}