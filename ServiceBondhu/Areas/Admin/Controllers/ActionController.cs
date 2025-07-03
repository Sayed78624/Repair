using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceBondhu.Data;
using ServiceBondhu.Models.Admin;

namespace ServiceBondhu.Areas.Admin.Controllers
{
    public class ActionController : Controller
    {
        private readonly ServiceDbContext db;
         public ActionController(ServiceDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var list =await db.ActionTypes.ToListAsync();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ActionType actionType)
        {
            if(ModelState.IsValid)
            {
                 db.ActionTypes.Add(actionType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(actionType);
        }
    }
}
