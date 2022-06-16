using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
