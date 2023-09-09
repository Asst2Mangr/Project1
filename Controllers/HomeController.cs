using Project1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display(ReaennModel model)
        {
            return View(model);
        }
    }
}
