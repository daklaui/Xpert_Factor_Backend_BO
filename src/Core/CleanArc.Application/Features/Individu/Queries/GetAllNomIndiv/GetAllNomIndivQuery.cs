using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllNomIndiv;

public record GetAllNomIndivQuery: IRequest<OperationResult<List<NomIndividuDto>>>;
