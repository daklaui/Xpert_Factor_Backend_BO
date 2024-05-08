using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Queries.GetAllPostalCodeQuery;

internal  class GetAllPostalCodeQuery_Handler:IRequestHandler<GetAllPostalCodeQuery,OperationResult<PageInfo<GetAllPostalCodeQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllPostalCodeQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetAllPostalCodeQuery_Response>>> Handle(GetAllPostalCodeQuery request, CancellationToken cancellationToken)
    {
        var ListPostalCode = await _unitOfWork.PostalCodesRepository.GetAllTPostalCodesAsync(request.PaginationParams);
        var result = new PageInfo<GetAllPostalCodeQuery_Response>
        {
            PageSize = ListPostalCode.PageSize,
            CurrentPage = ListPostalCode.CurrentPage,
            TotalPages = ListPostalCode.TotalPages,
            TotalCount = ListPostalCode.TotalCount,
            Result = ListPostalCode.Select(_mapper.Map<TR_CP,GetAllPostalCodeQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetAllPostalCodeQuery_Response>>.SuccessResult(result);
    }
}