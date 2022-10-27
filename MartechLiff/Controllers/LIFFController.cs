using MartechLiff.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace MartechLiff.Controllers
{
    public class LIFFController : Controller
    {
        private readonly IConfiguration _configuration;

        public LIFFController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task<IActionResult> HennessyLocation()
        {
            return Redirect("https://www.hennessy.com/zh-asia");
        }
    }
}
