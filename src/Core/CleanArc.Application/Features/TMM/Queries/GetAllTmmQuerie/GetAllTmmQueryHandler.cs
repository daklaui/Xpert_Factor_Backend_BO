using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TMM.Queries.GetAllTmmQuerie;

internal class GetAllTmmQueryHandler : IRequestHandler<GetAllTmmQuery, OperationResult<PageInfo<GetAllTmmQueryResult>>>
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
        var tmm = await _unitOfWork.TmmRepository.GetAllTrTmmAsync(request.paginationParams);
 
        var result = new PageInfo<GetAllTmmQueryResult>
        {
            PageSize = tmm.PageSize,
            CurrentPage = tmm.CurrentPage,
            TotalPages = tmm.TotalPages,
            TotalCount = tmm.TotalCount,
            Result = tmm.Select(_mapper.Map<TR_TMM, GetAllTmmQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllTmmQueryResult>>.SuccessResult(result);
    }
}