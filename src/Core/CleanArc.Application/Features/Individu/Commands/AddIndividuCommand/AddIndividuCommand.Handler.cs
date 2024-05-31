using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.Individu.Commands.AddIndividuCommand
{
    internal class AddIndividuCommandHandler : IRequestHandler<AddIndividuCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddIndividuCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddIndividuCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Adding the main individual entity
                await _unitOfWork.IndividualRepository.AddIndividualDTOAsync(request.individual);
                await _unitOfWork.CommitAsync();

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during Individual registration.", e);
                return OperationResult<bool>.FailureResult("An error occurred while adding the individual.");
            }
        }
    }
}