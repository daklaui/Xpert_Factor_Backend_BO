using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.RecouvrementList.Queries.GetAllFacturesEchu;

internal class GetAllFacturesEchuQuery_Handler:IRequestHandler<GetAllFacturesEchuQuery,OperationResult<PageInfo<GetAllFacturesEchuQuery_Response>>>
{
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllFacturesEchuQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetAllFacturesEchuQuery_Response>>> Handle(
        GetAllFacturesEchuQuery request, CancellationToken cancellationToken)
    {
        var LiteFactureEchu = await _unitOfWork.EncaissementRepository.GetAllFacturesEchu();
        var result = new PageInfo<GetAllFacturesEchuQuery_Response>()
        {
            PageSize = LiteFactureEchu.Count,
            CurrentPage = 1,
            TotalPages = 1,
            TotalCount = LiteFactureEchu.Count,
            Result = LiteFactureEchu.Select(_mapper.Map<T_RECOUVREMENT_DTO, GetAllFacturesEchuQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetAllFacturesEchuQuery_Response>>.SuccessResult(result);
    }
}