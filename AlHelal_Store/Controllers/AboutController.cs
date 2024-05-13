using Microsoft.AspNetCore.Mvc;

namespace AlHelal_Store.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
