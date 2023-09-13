using Project1.Models;
using Microsoft.AspNetCore.Mvc;

//controller page
namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Display(ReaennModel model)
        {
            if (ModelState.IsValid) 
            {
                return View(model);
            }
            else
            {
                return View("Index", model);
            }

        }
    }
}
