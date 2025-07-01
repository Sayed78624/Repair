using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceBondhu.Data;
using ServiceBondhu.Models.Admin;
using ServiceBondhu.ViewModels;

namespace ServiceBondhu.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ServiceDbContext db;
        public ServiceController(ServiceDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var listdata =await(from s in db.Services
                                join c in db.ServiceCategories
                                on s.CategoryId equals c.CategoryId
                                select new ServiceVM()
                                {
                                    ServiceId = s.ServiceId,
                                    CategoryName = c.CategoryName,
                                    ServiceName = s.ServiceName,
                                    Description = s.Description
                                }).ToListAsync();
            return View(listdata);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var catlist= await db.ServiceCategories.ToListAsync();
            var category = catlist.Select(c =>
            new SelectListItem
            {
                Value = c.CategoryId.ToString(),
                Text = c.CategoryName
            });
            ServiceVM serviceVM = new ServiceVM();
            serviceVM.Categories = category.ToList();
            return View(serviceVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ServiceVM serviceVM)
        {
            if(ModelState.IsValid)
            {
                Service service = new Service
                {
                    ServiceId = serviceVM.ServiceId,
                    ServiceName = serviceVM.ServiceName,
                    CategoryId = serviceVM.CategoryId,
                    Description = serviceVM.Description
                };
                db.Services.Add(service);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceVM);
        }
    }
}
