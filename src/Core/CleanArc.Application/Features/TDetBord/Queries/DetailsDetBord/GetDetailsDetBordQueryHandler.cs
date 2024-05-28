using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Queries.DetailsDetBord;

internal class GetDetailsDetBordQueryHandler: IRequestHandler<GetDetailsDetBordQuery, OperationResult<GetDetailsDetBordQueryResult>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetDetailsDetBordQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<GetDetailsDetBordQueryResult>> Handle(GetDetailsDetBordQuery request, CancellationToken cancellationToken)
    {
        var tDetBordList = await _unitOfWork.TDetBordRepository.getDetailsDetBord(request.PksDto);
        if (tDetBordList == null || !tDetBordList.Any())
        {
            return OperationResult<GetDetailsDetBordQueryResult>.FailureResult("No records found for the given primary keys.");
        }

        var result = new GetDetailsDetBordQueryResult
        {
            DetailsDetBordList = _mapper.Map<List<DetailsDetBordDto>>(tDetBordList)
        };

        return OperationResult<GetDetailsDetBordQueryResult>.SuccessResult(result);
    }
}