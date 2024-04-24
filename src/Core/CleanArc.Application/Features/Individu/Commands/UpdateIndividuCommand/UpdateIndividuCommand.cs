    using CleanArc.Application.Models.Common;
    using CleanArc.Domain.Entities;
    using Mediator;

    namespace CleanArc.Application.Features.Individu.Commands.UpdateIndividuCommand
    {
        public record UpdateIndividuCommand(T_INDIVIDU Individu) : IRequest<OperationResult<bool>>;
    }
