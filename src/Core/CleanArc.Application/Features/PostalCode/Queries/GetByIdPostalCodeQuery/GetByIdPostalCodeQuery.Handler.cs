using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Queries.GetByIdPostalCodeQuery;

internal class GetByIdPostalCodeQuery_Handler:IRequestHandler<GetByIdPostalCodeQuery,OperationResult<GetByIdPostalCodeQuery_Response>>
{  
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetByIdPostalCodeQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<GetByIdPostalCodeQuery_Response>> Handle(GetByIdPostalCodeQuery request, CancellationToken cancellationToken)
    {
        var PostalCode = await _unitOfWork.PostalCodesRepository.GetTPostalCodesById(request.id);

        var result =   _mapper.Map<TR_CP, GetByIdPostalCodeQuery_Response>(PostalCode);

        return OperationResult<GetByIdPostalCodeQuery_Response>.SuccessResult(result);
    }
}