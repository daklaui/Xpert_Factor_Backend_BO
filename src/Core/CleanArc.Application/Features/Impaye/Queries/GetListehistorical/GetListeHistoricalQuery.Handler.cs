using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Queries.GetListehistorical;

internal class GetListeHistoricalQuery_Handler : IRequestHandler<GetListeHistoricalQuery,
    OperationResult<PageInfo<GetListeHistoricalQuery_Response>>>
{
      
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetListeHistoricalQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetListeHistoricalQuery_Response>>> Handle(GetListeHistoricalQuery request, CancellationToken cancellationToken)
    {
        var impayeDtoList = _unitOfWork.ImpayeRepository.GetListehistorical();
        var result = new PageInfo<GetListeHistoricalQuery_Response>()
        {
            PageSize = impayeDtoList.Count,
            CurrentPage = 1, 
            TotalPages = 1, 
            TotalCount = impayeDtoList.Count,
            Result = impayeDtoList.Select(_mapper.Map<T_IMPAYE_DTO, GetListeHistoricalQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetListeHistoricalQuery_Response>>.SuccessResult(result);

    }
}
