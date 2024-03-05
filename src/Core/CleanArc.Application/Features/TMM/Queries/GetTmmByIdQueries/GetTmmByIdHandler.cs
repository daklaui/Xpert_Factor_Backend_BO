using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.TMM.Queries.GetAllTmmQueries;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TMM.Queries.GetTmmByIdQueries;

internal class GetTmmByIdHandler : IRequestHandler<GetTmmByIdQuery, OperationResult<GetTmmByIdQueryResult>>
{
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetTmmByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    
    public async ValueTask<OperationResult<GetTmmByIdQueryResult>> Handle(GetTmmByIdQuery request, CancellationToken cancellationToken)
    {
        var tmm = await _unitOfWork.TmmRepository.GetTmmByIdAsync(request.Tmmid);

        var result =   _mapper.Map<TRTMM, GetTmmByIdQueryResult>(tmm);

        return OperationResult<GetTmmByIdQueryResult>.SuccessResult(result);
    }
}