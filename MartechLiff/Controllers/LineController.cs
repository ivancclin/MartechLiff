using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace MartechLiff.Controllers
{
    public class LineController : Controller
    {
        private readonly IConfiguration _configuration;

        public LineController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLiff()
        {
            return View();
        }

    }
}
