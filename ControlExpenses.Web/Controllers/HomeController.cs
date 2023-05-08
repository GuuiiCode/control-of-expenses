using ControlExpenses.Domain.Entities;
using ControlExpenses.Domain.Enums;
using ControlExpenses.Domain.Interfaces.Repositories;
using ControlExpenses.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControlExpenses.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;
        private readonly ILogger<HomeController> _logger;


        public HomeController(IUnitOfWork unitOfWork,
                              IMediator mediator,
                              ILogger<HomeController> logger)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            // var command = new ContaCommand(3);
            //await  _mediator.Send(command);

            var teste = new ControlExpense("description", 15.50m, TypeEnum.Revenue, DateTime.Now);

            await _unitOfWork.ControlExpenseRepository.Add(teste);
            _unitOfWork.Save();

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