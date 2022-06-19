using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class LawyerController : Controller
    {
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
