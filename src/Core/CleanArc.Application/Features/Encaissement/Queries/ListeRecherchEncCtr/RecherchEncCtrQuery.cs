using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Encaissement.Queries.ListeRecherchEncCtr;

public record RecherchEncCtrQuery(int refCtr) : IRequest<OperationResult<List<RecherchEncCtrQuery_Response>>>;

