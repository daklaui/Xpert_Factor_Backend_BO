﻿using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetByIdQuery
{ internal class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, OperationResult<GetByIdQueryResult>>
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
            var individu = await _unitOfWork.IndividualRepository.GetIndividuByIdAsync(request.IndividuId);
            if (individu == null)
            {
                return OperationResult<GetByIdQueryResult>.FailureResult($"Individu with ID {request.IndividuId} not found");
            }

            var result = _mapper.Map<GetByIdQueryResult>(individu);
            return OperationResult<GetByIdQueryResult>.SuccessResult(result);
        }
    }
    
}
