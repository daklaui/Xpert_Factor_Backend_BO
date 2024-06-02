using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAcheteurPourContrat;

public record GetAcheteurPourContratQuery(int refctr) : IRequest<OperationResult<List<NomIndividuDto>>>;
