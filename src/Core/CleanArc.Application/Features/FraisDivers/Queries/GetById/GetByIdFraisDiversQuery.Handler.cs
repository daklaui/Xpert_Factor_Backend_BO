using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.FraisDivers.Queries.GetByIdQuery
{
    internal class GetByIdFraisDiversQueryHandler : IRequestHandler<GetByIdFraisDiversQuery, OperationResult<GetByIdFraisDiversQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdFraisDiversQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetByIdFraisDiversQueryResult>> Handle(GetByIdFraisDiversQuery request, CancellationToken cancellationToken)
        {
            var fraisDivers = await _unitOfWork.FraisDiversRepository.GetFraisDiversById(request.fraisDiversId);

            if (fraisDivers == null)
            {
                return OperationResult<GetByIdFraisDiversQueryResult>.FailureResult($"Frais Divers with id {request.fraisDiversId} not found.");
            }

            var result = _mapper.Map<T_FRAIS_DIVERS, GetByIdFraisDiversQueryResult>(fraisDivers);

            return OperationResult<GetByIdFraisDiversQueryResult>.SuccessResult(result);
        }
    }
}