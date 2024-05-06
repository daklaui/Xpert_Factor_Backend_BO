using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.User;
using Mediator;
using Microsoft.Extensions.Logging;

namespace CleanArc.Application.Features.Users.Commands.Create;

internal class UserCreateCommandHandler : IRequestHandler<UserCreateCommand, OperationResult<UserCreateCommandResult>>
{

    private readonly IAppUserManager _userManager;
    private readonly ILogger<UserCreateCommandHandler> _logger;
    public UserCreateCommandHandler(IAppUserManager userRepository, ILogger<UserCreateCommandHandler> logger)
    {
        _userManager = userRepository;
        _logger = logger;
    }

    public async ValueTask<OperationResult<UserCreateCommandResult>> Handle(UserCreateCommand request, CancellationToken cancellationToken)
    {
        var userNameExist = await _userManager.IsExistUser(request.LOGIN_USER);

        if (userNameExist)
            return OperationResult<UserCreateCommandResult>.FailureResult("Username already exists");

        var user = new User 
        { 
            NOM_USER = request.NOM_USER, 
            PRE_USER = request.PRE_USER, 
            LOGIN_USER = request.LOGIN_USER, 
            MDP_USER = request.MDP_USER, 
            ACTIF_USER = request.ACTIF_USER, 
            FONCTION_USER = request.FONCTION_USER, 
            SERVICE_USER = request.SERVICE_USER, 
            DIRECTION_USER = request.DIRECTION_USER, 
            AGENCE_USER = request.AGENCE_USER, 
            MAIL_USER = request.MAIL_USER, 
            TEL_FIXE_USER = request.TEL_FIXE_USER, 
            MOBILE_USER = request.MOBILE_USER, 
            PHOTO_USER = request.PHOTO_USER, 
            ONE_SIGNAL_PLAYER_ID = request.ONE_SIGNAL_PLAYER_ID 
        };

        var createResult = await _userManager.CreateUser(user);

        if (!createResult.Succeeded)
        {
            return OperationResult<UserCreateCommandResult>.FailureResult(string.Join(",", createResult.Errors.Select(c => c.Description)));
        }

        _logger.LogInformation($"User created successfully with username: {user.LOGIN_USER}");

        // Vous pouvez générer d'autres logiques ici, comme l'envoi d'un code de confirmation par SMS ou par e-mail

        return OperationResult<UserCreateCommandResult>.SuccessResult(new UserCreateCommandResult { UserGeneratedKey = user.GeneratedCode });
    }
}
