using Microsoft.AspNetCore.Mvc;

namespace LearnDotnetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}