﻿
using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TListVal.Queries.GetByIdQuery
{
    public record GetTListValByIdQuery(int tListValId) : IRequest<OperationResult<GetByIdQueryResult>>;
}
