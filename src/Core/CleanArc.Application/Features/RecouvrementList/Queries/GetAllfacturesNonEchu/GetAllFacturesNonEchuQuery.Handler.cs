using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.RecouvrementList.Queries.GetAllfacturesNonEchu;

internal class GetAllFacturesNonEchuQuery_Handler:IRequestHandler<GetAllFacturesNonEchuQuery,OperationResult<PageInfo<GetAllFacturesNonEchuQuery_Response>>>
{
       
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllFacturesNonEchuQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

 

    public async ValueTask<OperationResult<PageInfo<GetAllFacturesNonEchuQuery_Response>>> Handle(GetAllFacturesNonEchuQuery request, CancellationToken cancellationToken)
    {
        var LiteFactureNonEchu = await _unitOfWork.EncaissementRepository.GetAllFacturesNonEchu();
        var result = new PageInfo<GetAllFacturesNonEchuQuery_Response>()
        {
            PageSize = LiteFactureNonEchu.Count,
            CurrentPage = 1,
            TotalPages = 1,
            TotalCount = LiteFactureNonEchu.Count,
            Result = LiteFactureNonEchu.Select(_mapper.Map<T_RECOUVREMENT_DTO, GetAllFacturesNonEchuQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetAllFacturesNonEchuQuery_Response>>.SuccessResult(result);
    }
}
