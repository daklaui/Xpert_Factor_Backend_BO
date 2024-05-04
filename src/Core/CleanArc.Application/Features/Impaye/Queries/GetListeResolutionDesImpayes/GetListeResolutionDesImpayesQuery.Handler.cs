using AutoMapper;
using Azure;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Queries.GetListeResolutionDesImpayes;

internal class GetListeResolutionDesImpayesQuery_Handler:IRequestHandler<GetListeResolutionDesImpayesQuery,OperationResult<PageInfo<GetListeResolutionDesImpayesQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetListeResolutionDesImpayesQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetListeResolutionDesImpayesQuery_Response>>> Handle(GetListeResolutionDesImpayesQuery request, CancellationToken cancellationToken)
    {
        var impayeDtoList = _unitOfWork.ImpayeRepository.GetListeResolutionDesImpayes();
        var result = new PageInfo<GetListeResolutionDesImpayesQuery_Response>()
        {
            PageSize = impayeDtoList.Count,
            CurrentPage = 1, 
            TotalPages = 1, 
            TotalCount = impayeDtoList.Count,
            Result = impayeDtoList.Select(_mapper.Map<T_IMPAYE_DTO, GetListeResolutionDesImpayesQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetListeResolutionDesImpayesQuery_Response>>.SuccessResult(result);

    }
}