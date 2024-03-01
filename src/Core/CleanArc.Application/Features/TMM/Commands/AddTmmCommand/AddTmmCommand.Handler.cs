using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Individu.Commands.AddIndividuCommand;
using CleanArc.Application.Models.Common;
using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.TMM.Commands.AddTmmCommand
{
    internal class AddTmmCommandHandler : IRequestHandler<AddTmmCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddTmmCommandHandler(IUnitOfWork unitOfWork)
        {
            
            _unitOfWork = unitOfWork;
        }

            public async ValueTask<OperationResult<bool>> Handle(AddTmmCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.tmmRepository.AddTmmAsync(request.tmm);

            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }
    }
}
