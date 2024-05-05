using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.GetAllRecouvrement;

public record GetAllRecouvrementQuery(): IRequest<OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>>;