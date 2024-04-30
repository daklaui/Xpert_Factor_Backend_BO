using CleanArc.Application.Features.AgencyBank.Queries.RechercheBanqueQuerie;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.SearchAgencyQuerie;

public record SearchAgencyQuery(string id) : IRequest<OperationResult<SearchAgencyQueryResult>>;
