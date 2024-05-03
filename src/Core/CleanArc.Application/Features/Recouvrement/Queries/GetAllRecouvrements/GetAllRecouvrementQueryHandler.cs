using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.Queries.GetAllRecouvrements;

public class GetAllRecouvrementQueryHandler: IRequestHandler<GetAllRecouvrementQuery,OperationResult<PageInfo<GetAllRecouvrementQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllRecouvrementQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<PageInfo<GetAllRecouvrementQueryResult>>> Handle(GetAllRecouvrementQuery request, CancellationToken cancellationToken)
    {
        var Recourvrement = await _unitOfWork.RecouvrementRepository.GetAllRecAsync(request.paginationParams);
 
        var result = new PageInfo<GetAllRecouvrementQueryResult>
        {
            PageSize = Recourvrement.PageSize,
            CurrentPage = Recourvrement.CurrentPage,
            TotalPages = Recourvrement.TotalPages,
            TotalCount = Recourvrement.TotalCount,
            Result = Recourvrement.Select(_mapper.Map<TR_LIST_VAL, GetAllRecouvrementQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllRecouvrementQueryResult>>.SuccessResult(result);
    }
}