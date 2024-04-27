using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;
using static System.Linq.AsyncEnumerable;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetAllBordereaux;

internal class GetAllBordereauxQueryHandler : IRequestHandler<GetAllBordereauxQuery, OperationResult<PageInfo<GetAllBordereauxQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllBordereauxQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetAllBordereauxQueryResult>>> Handle(GetAllBordereauxQuery request, CancellationToken cancellationToken)
    {
        
        var bordereauxTask = _unitOfWork.BordereauxRepository.GetAllBordereauxAsync(request.paginationParams);
        var detBordsTask = _unitOfWork.TDetBordRepository.GetAllT_DET_BORD_Async(request.paginationParams);

       
        await Task.WhenAll(bordereauxTask, detBordsTask);

        var bordereaux = await bordereauxTask;
        var detBords = await detBordsTask;

        
        var mappedBordereaux = bordereaux.Select(b =>
        {
            var dto = _mapper.Map<T_BORDEREAU, BordereauDTO>(b);
            dto.DetBords = _mapper.Map<List<T_DET_BORD>, List<T_det_bord_DTO>>(detBords.Where(d =>
                d.NUM_BORD == b.NUM_BORD &&
                d.REF_CTR_DET_BORD == b.REF_CTR_BORD &&
                d.ANNEE_BORD == b.ANNEE_BORD
            ).ToList());
            return dto;
        }).ToList();


        var result = new PageInfo<GetAllBordereauxQueryResult>
        {
            PageSize = bordereaux.PageSize,
            CurrentPage = bordereaux.CurrentPage,
            TotalPages = bordereaux.TotalPages,
            TotalCount = bordereaux.TotalCount,
            Result = mappedBordereaux.Select(dto => new GetAllBordereauxQueryResult { Bordereau = dto }).ToList()
        };

        return OperationResult<PageInfo<GetAllBordereauxQueryResult>>.SuccessResult(result);
    }
}