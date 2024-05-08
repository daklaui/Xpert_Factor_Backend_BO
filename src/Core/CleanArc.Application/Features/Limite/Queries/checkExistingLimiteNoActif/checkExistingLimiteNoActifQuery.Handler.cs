using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries.checkExistingLimiteNoActif;


internal class checkExistingLimiteNoActifQuery_Handler:IRequestHandler<CheckExistingLimiteNoActifQuery,OperationResult<checkExistingLimiteNoActif_Response>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public checkExistingLimiteNoActifQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<checkExistingLimiteNoActif_Response>> Handle(CheckExistingLimiteNoActifQuery request, CancellationToken cancellationToken)
    {
        var limite = await _unitOfWork.LimiteRepository.checkExistingLimiteNoActif(request.REF_DEM_LIM,request.REF_CTR_DEM_LIM);
        var result =   _mapper.Map<T_DEM_LIMITE_DTO ,checkExistingLimiteNoActif_Response>(limite);
        return OperationResult<checkExistingLimiteNoActif_Response>.SuccessResult(result);

    }
}