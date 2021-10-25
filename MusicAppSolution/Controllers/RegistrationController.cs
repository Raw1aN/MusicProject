using Microsoft.AspNetCore.Mvc;

namespace MusicAppProject.Controllers
{
    public class RegistrationController : Controller
    {
        // GET
        public IActionResult Registration()
        {
            return View();
        }
    }
}