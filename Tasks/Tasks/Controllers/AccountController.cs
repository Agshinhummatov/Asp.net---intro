using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<string> _users = new List<string>() { "Aqsin", "Ali", "Roya" };

            return View(_users);
        }
    }
}
