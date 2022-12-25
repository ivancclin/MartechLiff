using Microsoft.AspNetCore.Mvc;

namespace MartechLiff.Controllers
{
    public class LaprairieController : Controller
    {
        public LaprairieController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
