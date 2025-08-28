using Microsoft.AspNetCore.Mvc;

namespace laptrinhwebbaitap1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Tung";
            return View();
        }
        public IActionResult Sample() 
        {

            return View("Index"); 
        }   
    }
}
