using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Queries.GetById;

internal class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, OperationResult<GetByIdQueryResult>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<GetByIdQueryResult>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        var TDetBord = await _unitOfWork.TDetBordRepository.GetT_DET_BORD_Byid(request.TDetBordId);

        var result =   _mapper.Map<T_DET_BORD, GetByIdQueryResult>(TDetBord);

        return OperationResult<GetByIdQueryResult>.SuccessResult(result);
    }
}