using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Lawyer()
        {
            return View();
        }

        public IActionResult LawyerSingle()
        {
            return View();
        }
    }
}
