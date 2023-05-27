using ControlExpenses.Application.Commands.ControlExpense.Commands;
using ControlExpenses.Domain.Enums;
using ControlExpenses.Models;
using ControlExpenses.CrossCutting.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControlExpenses.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommandBus _commandBus;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ICommandBus commandBus,
                              ILogger<HomeController> logger)
        {
            _commandBus = commandBus;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //var testeCommand = new UpdateControlExpenseCommand("rosimeire update", 55m, TypeEnum.Expense, DateTime.Now);
            //testeCommand.Id = 4;
            int a = -1;
            var testeCommand = new DeleteControlExpenseCommand(a);

            await _commandBus.Send(testeCommand);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}