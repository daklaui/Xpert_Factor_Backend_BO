using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;
 
namespace CleanArc.Application.Features.Contrat.Queries.GetAllContracts
{
    public class GetAllContractsQueryHandler : IRequestHandler<GetAllContractsQuery, OperationResult<PageInfo<GetAllContractsQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllContractsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async ValueTask<OperationResult<PageInfo<GetAllContractsQueryResult>>> Handle(GetAllContractsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var contracts = await _unitOfWork.ContratRepository.GetAllContratAsync(request.PaginationParams); 

                var pageInfo = new PageInfo<GetAllContractsQueryResult>
                {
                    PageSize = contracts.PageSize,
                    CurrentPage = contracts.CurrentPage,
                    TotalPages = contracts.TotalPages,
                    TotalCount = contracts.TotalCount,
                    Result =   contracts.Select(_mapper.Map<ListeDesContrats_Result, GetAllContractsQueryResult>).ToList()
                };

                return OperationResult<PageInfo<GetAllContractsQueryResult>>.SuccessResult(pageInfo);
            }
            catch (Exception ex)
            {
                return OperationResult<PageInfo<GetAllContractsQueryResult>>.FailureResult(ex.Message);
            }
        }
    }
}
