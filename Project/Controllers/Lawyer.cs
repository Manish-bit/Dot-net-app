using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class Lawyer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
