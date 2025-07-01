using Microsoft.AspNetCore.Mvc;
using ServiceBondhu.Data;
using ServiceBondhu.Models.Admin;
using ServiceBondhu.ViewModels;

namespace ServiceBondhu.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ServiceDbContext db;
        public CategoryController(ServiceDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var list = db.ServiceCategories.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryVM category)
        {
            if(ModelState.IsValid)
            {
                ServiceCategory serviceCategory = new ServiceCategory
                {
                    CategoryName = category.CategoryName,
                };
                db.ServiceCategories.Add(serviceCategory);
                db.SaveChanges();
                return RedirectToAction ("Index");
            }
            return View(category);
        }
    }
}
