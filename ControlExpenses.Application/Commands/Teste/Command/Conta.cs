using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ControlExpenses.Application.Commands.Teste.Command
{
    public class ContaCommand : IRequest<bool>
    {
        public ContaCommand(int myProperty)
        {
            MyProperty = myProperty;
        }

        public int MyProperty { get; set; }
    }

    public class ContaCommandHandler : IRequestHandler<ContaCommand, bool>
    {
        public async Task<bool> Handle(ContaCommand request, CancellationToken cancellationToken)
        {
             Console.WriteLine(request);
            return true;
        }
    }
}
