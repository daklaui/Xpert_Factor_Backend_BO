using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries.GetAllListOfDemLimitNoActif;

public class GetAllListOfDemLimitNoActifQuery_Handler:IRequestHandler<GetAllListOfDemLimitNoActifQuery,OperationResult<PageInfo<GetAllListOfDemLimitNoActifQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllListOfDemLimitNoActifQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public  async ValueTask<OperationResult<PageInfo<GetAllListOfDemLimitNoActifQuery_Response>>> Handle(GetAllListOfDemLimitNoActifQuery request, CancellationToken cancellationToken)
    {
        var limite = await _unitOfWork.LimiteRepository.GetAllListOfDemLimitNoActif(request.paginationParams);
        var result = new PageInfo<GetAllListOfDemLimitNoActifQuery_Response>
        {
            PageSize = limite.PageSize,
            CurrentPage = limite.CurrentPage,
            TotalPages = limite.TotalPages,
            TotalCount = limite.TotalCount,
            Result = limite.Select(_mapper.Map<T_DEM_LIMITE,GetAllListOfDemLimitNoActifQuery_Response>).ToList()

        };
        return OperationResult<PageInfo<GetAllListOfDemLimitNoActifQuery_Response>>.SuccessResult(result);
    }
}