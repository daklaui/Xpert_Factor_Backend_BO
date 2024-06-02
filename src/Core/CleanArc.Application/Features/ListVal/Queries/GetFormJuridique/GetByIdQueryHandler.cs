using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Queries.GetFormJuridique
{
    internal class GetFormJuridiqueQueryHandler : IRequestHandler<GetFormJuridiqueQuery, OperationResult<List<GetFormJuridiqueQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFormJuridiqueQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<List<GetFormJuridiqueQueryResult>>> Handle(GetFormJuridiqueQuery request, CancellationToken cancellationToken)
        {
            var listVal = await _unitOfWork.ListValRepository.GetFormJuridique();

            var result = listVal.Select(_mapper.Map<TR_LIST_VAL, GetFormJuridiqueQueryResult>).ToList();

            return OperationResult< List<GetFormJuridiqueQueryResult>>.SuccessResult(result);
        }
    }
}