﻿using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.User;
using CleanArc.SharedKernel.Extensions;
using Mediator;

namespace CleanArc.Application.Features.Individu.Commands.AddIndividuCommand
{
    internal class AddContactCommandHandler : IRequestHandler<AddIndividuCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppUserManager _userManager;

        public AddContactCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddIndividuCommand request, CancellationToken cancellationToken)
        {
             await _unitOfWork.IndividualRepository.AddIIndividualAsync(request.Individu);

             await _unitOfWork.CommitAsync();

             return OperationResult<bool>.SuccessResult(true);
        }
    }
}
