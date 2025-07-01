using Microsoft.AspNetCore.Mvc;

namespace ServiceBondhu.Areas.Admin.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
