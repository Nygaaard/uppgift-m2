using Microsoft.AspNetCore.Mvc;

namespace uppgiftm2.Namespace
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}