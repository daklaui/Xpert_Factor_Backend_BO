﻿using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.TPostalCodes.Queries.GetAllTPostalCodes
{
    internal class GetAllTPostalCodesQueryHandler : IRequestHandler<GetAllTPostalCodesQuery, OperationResult<PageInfo<GetAllTPostalCodesQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTPostalCodesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<PageInfo<GetAllTPostalCodesQueryResult>>> Handle(GetAllTPostalCodesQuery request, CancellationToken cancellationToken)
        {
            var tPostalCodes = await _unitOfWork.TPostalCodesRepository.GetAllTPostalCodesAsync(request.PaginationParams);

            if (tPostalCodes == null)
            {
                return OperationResult<PageInfo<GetAllTPostalCodesQueryResult>>.FailureResult("Failed to retrieve TPostalCodes");
            }

            var result = new PageInfo<GetAllTPostalCodesQueryResult>
            {
                PageSize = tPostalCodes.PageSize,
                CurrentPage = tPostalCodes.CurrentPage,
                TotalPages = tPostalCodes.TotalPages,
                TotalCount = tPostalCodes.TotalCount,
                Result = tPostalCodes.Select(_mapper.Map<Domain.Entities.TPostalCodes, GetAllTPostalCodesQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllTPostalCodesQueryResult>>.SuccessResult(result);
        }
    }
}