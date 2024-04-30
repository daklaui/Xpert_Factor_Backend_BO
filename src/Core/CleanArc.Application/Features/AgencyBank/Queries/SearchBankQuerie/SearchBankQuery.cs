using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.RechercheBanqueQuerie;

public record SearchBankQuery(string id) : IRequest<OperationResult<SearchBankQueryResult>>;
