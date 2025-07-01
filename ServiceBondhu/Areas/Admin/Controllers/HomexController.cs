using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using ServiceBondhu.ViewModels;

namespace ServiceBondhu.Areas.Admin.Controllers
{
    public class HomexController : Controller
    {
        private readonly ILogger<HomexController> _logger;

        public HomexController(ILogger<HomexController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
