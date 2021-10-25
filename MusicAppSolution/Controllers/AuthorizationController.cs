using Microsoft.AspNetCore.Mvc;

namespace MusicAppProject.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET
        public IActionResult Authorization()
        {
            return View();
        }
    }
}