using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetById;

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
        try
        {
            var bordereaux = await _unitOfWork.BordereauxRepository.GetBordereauxByPK(
                request.BordereauxId.NUM_BORD,
                request.BordereauxId.REF_CTR_BORD,
                request.BordereauxId.ANNEE_BORD);

            if (bordereaux != null)
            {
                var detBords = await _unitOfWork.TDetBordRepository.GetDetBordByPK(
                    request.BordereauxId.NUM_BORD,
                    request.BordereauxId.REF_CTR_BORD,
                    request.BordereauxId.ANNEE_BORD);

                var detBordDtos = detBords != null ? _mapper.Map<List<T_det_bord_DTO>>(detBords) : new List<T_det_bord_DTO>(); // Handle empty list
            
                var result = new GetByIdQueryResult
                {
                    Bordereau = _mapper.Map<BordereauDTO>(bordereaux, opt =>
                    {
                        opt.AfterMap((src, dest) =>
                        {
                            dest.Bordereau = bordereaux;
                            dest.DetBords = detBordDtos;
                        });
                    })
                };
                return OperationResult<GetByIdQueryResult>.SuccessResult(result);
            }
            else
            {
                return OperationResult<GetByIdQueryResult>.NotFoundResult("Bordereau not found.");
            }
        }
        catch (Exception ex)
        {
            return OperationResult<GetByIdQueryResult>.NotFoundResult("Error retrieving bordereau.");
        }
    }


}