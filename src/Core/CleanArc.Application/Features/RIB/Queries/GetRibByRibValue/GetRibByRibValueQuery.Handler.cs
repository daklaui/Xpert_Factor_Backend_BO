using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.RIB.Queries.GetRibByRibValue;

internal class GetRibByRibValueQuery_Handler: IRequestHandler<GetRibByRibValueQuery, OperationResult<GetRibByRibValueQuery_Response>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetRibByRibValueQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<GetRibByRibValueQuery_Response>> Handle(GetRibByRibValueQuery request, CancellationToken cancellationToken)
    {
        var rib = await _unitOfWork.ribRepository.GetRibByRibValueAsync(request.rib);
        if (rib == null)
        {
            return OperationResult<GetRibByRibValueQuery_Response>.FailureResult($"rib with ID {request.rib} not found");
        }

        var result = _mapper.Map<GetRibByRibValueQuery_Response>(rib);
        return OperationResult<GetRibByRibValueQuery_Response>.SuccessResult(result);
    }
}
    
