using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries.checkExistingLimiteNoActif;

public record CheckExistingLimiteNoActifQuery
    (int REF_DEM_LIM, int REF_CTR_DEM_LIM) :  IRequest<OperationResult<checkExistingLimiteNoActif_Response>>;
