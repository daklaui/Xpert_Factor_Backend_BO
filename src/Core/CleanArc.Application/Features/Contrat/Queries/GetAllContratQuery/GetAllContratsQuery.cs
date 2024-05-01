﻿using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Queries.GetAllContrats
{
    public record GetAllContratsQuery() : IRequest<OperationResult<PageInfo<GetAllContratsQueryResult>>>;
}