using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.GetAgnecyBankByIdQuerie;

public record GetAgencyBankByIdQuery(string codeAgBq) : IRequest<OperationResult<GetByIdQueryResult>>;
