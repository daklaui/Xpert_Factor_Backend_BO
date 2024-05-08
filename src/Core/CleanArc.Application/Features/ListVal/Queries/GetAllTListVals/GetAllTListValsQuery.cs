﻿using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Queries.GetAllTListVals
{
    public record GetAllTListValsQuery(PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetAllTListValsQueryResult>>>;
}