using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Queries;

internal class GetListOfImpayeQuey_Handler :IRequestHandler<GetListOfImpayeQuery,OperationResult<PageInfo<GetListOfImpayeQuery_Response>>>
{
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetListOfImpayeQuey_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetListOfImpayeQuery_Response>>> Handle(GetListOfImpayeQuery request, CancellationToken cancellationToken)
    {
        var impayeDtoList = _unitOfWork.ImpayeRepository.Listedesimpaye();
        var result = new PageInfo<GetListOfImpayeQuery_Response>()
        {
            PageSize = impayeDtoList.Count,
            CurrentPage = 1, 
            TotalPages = 1, 
            TotalCount = impayeDtoList.Count,
            Result = impayeDtoList.Select(_mapper.Map<T_IMPAYE_DTO, GetListOfImpayeQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetListOfImpayeQuery_Response>>.SuccessResult(result);
        
    }
}