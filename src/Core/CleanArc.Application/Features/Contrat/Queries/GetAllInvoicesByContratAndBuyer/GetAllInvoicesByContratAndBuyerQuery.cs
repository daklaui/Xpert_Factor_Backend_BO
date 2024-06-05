using CleanArc.Application.Models.Common;
using CleanArc.Domain.StoredProcuderModel;
using Mediator;


namespace CleanArc.Application.Features.Contrat.Queries.GetAllInvoicesByContratAndBuyer;

public record GetAllInvoicesByContratAndBuyerQuery(int id1,int id2): IRequest<OperationResult<List<ListeFactureValiderk>>>;
