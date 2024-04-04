using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Queries.GetAllTDetBord;

internal class GetAllTDetBordQueryHandler: IRequestHandler<GetAllTDetBordQuery,OperationResult<PageInfo<GetAllTDetBordQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllTDetBordQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<PageInfo<GetAllTDetBordQueryResult>>> Handle(GetAllTDetBordQuery request, CancellationToken cancellationToken)
    {
        var TDetBord = await _unitOfWork.TDetBordRepository.GetAllT_DET_BORD_Async(request.paginationParams);
 
        var result = new PageInfo<GetAllTDetBordQueryResult>
        {
            PageSize = TDetBord.PageSize,
            CurrentPage = TDetBord.CurrentPage,
            TotalPages = TDetBord.TotalPages,
            TotalCount = TDetBord.TotalCount,
            Result = TDetBord.Select(_mapper.Map<T_DET_BORD, GetAllTDetBordQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllTDetBordQueryResult>>.SuccessResult(result);
    }
}