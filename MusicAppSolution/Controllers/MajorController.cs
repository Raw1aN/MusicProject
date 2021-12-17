using Microsoft.AspNetCore.Mvc;

namespace MusicAppProject.Controllers
{
    public class MajorController : Controller
    {
        // GET
        public IActionResult Major()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}