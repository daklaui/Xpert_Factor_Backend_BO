using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Encaissement.Queries.ListeEncAchRefCtr;

public record ListeEncAchRefCtrQuery(int refCtr, int refAch) : IRequest<OperationResult<List<ListeEncAchRefCtrQuery_Response>>>;

