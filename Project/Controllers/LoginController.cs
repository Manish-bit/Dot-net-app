using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
