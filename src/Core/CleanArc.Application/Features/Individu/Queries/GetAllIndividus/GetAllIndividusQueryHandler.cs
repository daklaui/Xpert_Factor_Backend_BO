using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllIndividus
{
    internal class GetAllIndividusQueryHandler : IRequestHandler<GetAllIndividusQuery, OperationResult<PageInfo<GetAllIndividusQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllIndividusQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllIndividusQueryResult>>> Handle(GetAllIndividusQuery request, CancellationToken cancellationToken)
        {
            var individus = await _unitOfWork.IndividualRepository.GetAllIndividualDTOsAsync(request.paginationParams);
            
            var result = new PageInfo<GetAllIndividusQueryResult>
            {
                PageSize = individus.PageSize,
                CurrentPage = individus.CurrentPage,
                TotalPages = individus.TotalPages,
                TotalCount = individus.TotalCount,
                Result = individus.Result.Select(_mapper.Map<IndividualDTO, GetAllIndividusQueryResult>).ToList()
            };
            
            return OperationResult<PageInfo<GetAllIndividusQueryResult>>.SuccessResult(result);
        }
    }
}