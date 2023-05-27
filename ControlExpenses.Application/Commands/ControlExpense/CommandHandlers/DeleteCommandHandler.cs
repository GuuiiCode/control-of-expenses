using ControlExpenses.Application.Commands.ControlExpense.Commands;
using ControlExpenses.Domain.Interfaces.Repositories;
using ControlExpenses.CrossCutting.Interfaces;
using ControlExpenses.CrossCutting.Models;

namespace ControlExpenses.Application.Commands.ControlExpense.CommandHandlers
{
    public class DeleteCommandHandler : ICommandHandler<DeleteControlExpenseCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CommandResult> Handle(DeleteControlExpenseCommand request, CancellationToken cancellationToken)
        {
            var controlExpense = await _unitOfWork.ControlExpenseRepository.GetAsync(request.Id);

            if (controlExpense == null)
                return new CommandResult(false, request.Id);

            _unitOfWork.ControlExpenseRepository.Remove(controlExpense);
            var result = await _unitOfWork.SaveAsync();

            return new CommandResult(result > 0, request.Id);
        }
    }
}
