using Microsoft.AspNetCore.Mvc;

namespace laptrinhwebbaitap1.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            ViewData["Name"] = "RTX 3060";
            ViewData["NSX"] = "2021";
            ViewData["Owner"] = "NVIDIA";
            return View();
        }
    }
}
