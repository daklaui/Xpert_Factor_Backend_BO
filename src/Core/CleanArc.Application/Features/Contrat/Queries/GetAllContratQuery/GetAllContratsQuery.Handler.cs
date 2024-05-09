using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.Contrat.Queries.GetAllContrats
{
    public class GetAllContratsQueryHandler : IRequestHandler<GetAllContratsQuery, OperationResult<PageInfo<GetAllContratsQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllContratsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<int> Handle(GetContractsForCurrentYearQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.ContratRepository.GetContractsForCurrentYearasync();
        }

        public ValueTask<OperationResult<PageInfo<GetAllContratsQueryResult>>> Handle(GetAllContratsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
