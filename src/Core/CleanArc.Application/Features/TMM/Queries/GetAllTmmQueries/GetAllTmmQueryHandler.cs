using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TMM.Queries.GetAllTmmQueries;

internal class GetAllTmmQueryHandler:IRequestHandler<GetAllTmmQuery,OperationResult<PageInfo<GetAllTmmQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public GetAllTmmQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    
    public async ValueTask<OperationResult<PageInfo<GetAllTmmQueryResult>>> Handle(GetAllTmmQuery request, CancellationToken cancellationToken)
    {
        var Tmm = await _unitOfWork.TmmRepository.GetAllTmmAsync(request.paginationParams);
 
        var result = new PageInfo<GetAllTmmQueryResult>
        {
            PageSize = Tmm.PageSize,
            CurrentPage = Tmm.CurrentPage,
            TotalPages = Tmm.TotalPages,
            TotalCount = Tmm.TotalCount,
            Result = Tmm.Select(_mapper.Map<TRTMM, GetAllTmmQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllTmmQueryResult>>.SuccessResult(result);
    }
}