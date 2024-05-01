using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

// Assurez-vous que cette directive est incluse

namespace CleanArc.Application.Features.Contrat.Queries.GetAllContracts
{
    public class GetAllContractsQuery : IRequest<OperationResult<PageInfo<GetAllContractsQueryResult>>>
    {
        public PaginationParams PaginationParams { get; set; } 
    }
}