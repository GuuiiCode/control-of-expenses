using Microsoft.AspNetCore.Mvc;

namespace ControlExpenses.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
