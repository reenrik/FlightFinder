using Microsoft.AspNetCore.Mvc;

namespace FlightFinder
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
