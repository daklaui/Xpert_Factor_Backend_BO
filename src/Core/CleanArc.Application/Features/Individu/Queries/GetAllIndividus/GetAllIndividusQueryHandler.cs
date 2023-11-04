using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Users.Queries.GetUsers;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.User;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllIndividus
{
    internal class GetAllIndividusQueryHandler : IRequestHandler<GetAllIndividusQuery,OperationResult<List<GetAllIndividusQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllIndividusQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<List<GetAllIndividusQueryResult>>> Handle(GetAllIndividusQuery request, CancellationToken cancellationToken)
        {
            var individus = await _unitOfWork.IndividualRepository.GetAllIndividusAsync();

            var result = individus.Select(_mapper.Map<TIndividu, GetAllIndividusQueryResult>).ToList();

            return OperationResult<List<GetAllIndividusQueryResult>>.SuccessResult(result);
        }
    }
}
