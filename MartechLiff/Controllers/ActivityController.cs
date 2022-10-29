using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace MartechLiff.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IConfiguration _configuration;

        public ActivityController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Moet()
        {
            return View();
        }

    }
}
