using System.Text.RegularExpressions;
using CleanArc.Application.Models.Common;
using CleanArc.SharedKernel.ValidationBase;
using CleanArc.SharedKernel.ValidationBase.Contracts;
using FluentValidation;
using Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Application.Features.Users.Commands.Create;

public record UserCreateCommand
    (string NOM_USER, string PRE_USER, string LOGIN_USER, string MDP_USER, bool ACTIF_USER, string FONCTION_USER, string SERVICE_USER, string DIRECTION_USER, string AGENCE_USER, string MAIL_USER, string TEL_FIXE_USER, string MOBILE_USER, string PHOTO_USER, string ONE_SIGNAL_PLAYER_ID) : IRequest<OperationResult<UserCreateCommandResult>>, IValidatableModel<UserCreateCommand>
{

    public IValidator<UserCreateCommand> ValidateApplicationModel(ApplicationBaseValidationModelProvider<UserCreateCommand> validator)
    {

        validator
            .RuleFor(c => c.NOM_USER)
            .NotEmpty()
            .NotNull()
            .WithMessage("User must have a last name");

        validator
            .RuleFor(c => c.PRE_USER)
            .NotEmpty()
            .NotNull()
            .WithMessage("User must have a first name");

        validator
            .RuleFor(c => c.LOGIN_USER)
            .NotEmpty()
            .NotNull()
            .WithMessage("Please enter a username");

        validator
            .RuleFor(c => c.MDP_USER)
            .NotEmpty()
            .NotNull()
            .WithMessage("Please enter a password");

        validator
            .RuleFor(c => c.ACTIF_USER)
            .NotNull()
            .WithMessage("Please specify whether the user is active");

        validator
            .RuleFor(c => c.FONCTION_USER)
            .NotEmpty()
            .NotNull()
            .WithMessage("Please specify the user's function");

        // Ajoutez des règles de validation pour les autres attributs ici selon vos besoins

        return validator;
    }
}