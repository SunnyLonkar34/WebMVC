using Microsoft.AspNetCore.Mvc;
namespace WebMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Heading"] = TempData["Heading"];
            ViewData["NoOfStudents"] = 10;
            ViewData["CurrentDateTime"] = DateTime.Now;
            return View();
        }
        public IActionResult Index1()
        {
            ViewBag.Heading = "Hello";
            ViewBag.NoOfStudents = 100;
            ViewBag.CurrentDateTime = DateTime.Now;
            
            return View();
        }

        public IActionResult Index2()
        {
            TempData["Heading"] = "I am TempDataWebMVC";

            return RedirectToAction(nameof(Index));
        }
    }
}
