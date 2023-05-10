using CrossCutting.Domain.Interfaces;
using MediatR;

namespace CrossCutting.Domain.Models
{
    public class CommandBus : ICommandBus
    {
        private readonly IMediator _mediator;

        public CommandBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CommandResult> Send(ICommand command, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(command, cancellationToken);
        }
    }
}
