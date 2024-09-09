using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.RechercheBanqueQuerie;

public record SearchBankQuery(string codeBank) : IRequest<OperationResult<SearchBankQueryResult>>;
