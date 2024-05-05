using AutoMapper;
using Azure;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Application.Models.Identity;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.GetAllRecouvrement;

public class GetAllRecouvrementQueryHandler : IRequestHandler<GetAllRecouvrementQuery,OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public GetAllRecouvrementQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async ValueTask<OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>> Handle(GetAllRecouvrementQuery request, CancellationToken cancellationToken)
    {
        var Recouvrement = await _unitOfWork.RecouvrementRepository.GetAllRecouvrementQuery(request.paginationParams)
        var result = new PageInfo<GetAllRecouvrementQuery_Response>
        {
            PageSize = Recouvrement.Count,
            CurrentPage = 1,
            TotalPages = 10,
            TotalCount = Recouvrement.Count,
            Result = Recouvrement.Select(_mapper.Map<RecouvrementDto, GetAllRecouvrementQuery_Response>).ToList()

        };
        return OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>.SuccessResult(result);

    }
    
}