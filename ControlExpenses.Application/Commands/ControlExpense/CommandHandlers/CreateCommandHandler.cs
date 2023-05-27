using ControlExpenses.Application.Commands.ControlExpense.Commands;
using ControlExpenses.Domain.Interfaces.Repositories;
using ControlExpenses.CrossCutting.Interfaces;
using ControlExpenses.CrossCutting.Models;

namespace ControlExpenses.Application.Commands.ControlExpense.CommandHandlers
{
    public class CreateCommandHandler : ICommandHandler<CreateControlExpenseCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CommandResult> Handle(CreateControlExpenseCommand request, CancellationToken cancellationToken)
        {
            var teste = new Domain.Entities.ControlExpense(request.Description, request.Value, request.Type, request.Date);

            await _unitOfWork.ControlExpenseRepository.AddAsync(teste);
            var result = await _unitOfWork.SaveAsync();

            return new CommandResult(result > 0, teste.Id);
        }
    }
}
