using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetIndividusSansContrat;

public record GetIndividusSansContratQuery (int refctr) : IRequest<OperationResult<List<NomIndividuDto>>>;
