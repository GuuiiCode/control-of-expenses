using ControlExpenses.Application.Commands.ControlExpense.Commands;
using ControlExpenses.Domain.Interfaces.Repositories;
using ControlExpenses.CrossCutting.Interfaces;
using ControlExpenses.CrossCutting.Models;

namespace ControlExpenses.Application.Commands.ControlExpense.CommandHandlers
{
    public class UpdateCommandHandler : ICommandHandler<UpdateControlExpenseCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CommandResult> Handle(UpdateControlExpenseCommand request, CancellationToken cancellationToken)
        {
            var controlExpense = await _unitOfWork.ControlExpenseRepository.GetAsync(request.Id);

            if (controlExpense == null)
                return new CommandResult(false, request.Id);

            controlExpense.Change(request.Description, request.Value, request.Type, request.Date);

            _unitOfWork.ControlExpenseRepository.Update(controlExpense);
            var result = await _unitOfWork.SaveAsync();

            return new CommandResult(result > 0, request.Id);
        }
    }
}
