using Azure;
using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.GetAgnecyBankByIdQuerie;

public record GetAllAgencyBankQuery(PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllAgencyBankQueryResult>>>;
