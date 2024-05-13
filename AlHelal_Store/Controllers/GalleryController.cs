using Microsoft.AspNetCore.Mvc;

namespace AlHelal_Store.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
