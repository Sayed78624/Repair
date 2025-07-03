using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceBondhu.Data;
using ServiceBondhu.Models.Admin;
using ServiceBondhu.ViewModels;

namespace ServiceBondhu.Areas.Admin.Controllers
{
    public class MechanicController : Controller
    {
        private readonly ServiceDbContext db;
        public MechanicController(ServiceDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var list = await (db.Mechanics.Include(s =>s.Service).Select(m => new MechanicVM
            {
                MechanicId = m.MechanicId,
                MechanicName = m.MechanicName,
                Phone = m.Phone,
                Email = m.Email,
                ServiceName =m.Service.ServiceName

            }).ToListAsync());
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var servicelist =await db.Services.ToListAsync();
            var service = servicelist.Select(s => new SelectListItem
            {
                Value = s.ServiceId.ToString(),
                Text = s.ServiceName,
            });
            MechanicVM mechanicVM = new MechanicVM();
            mechanicVM.ServiceList = service.ToList();
            return View(mechanicVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MechanicVM mechanicVM)
        {
            if (ModelState.IsValid)
            {
                Mechanic mechanic = new Mechanic
                {
                    MechanicName = mechanicVM.MechanicName,
                    Phone = mechanicVM.Phone,
                    Email = mechanicVM.Email,
                    ServiceId = mechanicVM.ServiceId
                };
                db.Mechanics.Add(mechanic);
                
                await db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(mechanicVM);
        }
        //public async Task<IActionResult> CreateDetail(MechanicServiceVM mechanicServiceVM)
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        MechanicService mechanicService = new MechanicService
        //        {
        //            MechanicId = mechanicServiceVM.MechanicId,
        //            ServiceId = mechanicServiceVM.ServiceId,
        //        };
        //        db.MechanicServices.Add(mechanicService);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(mechanicServiceVM);
        //}
    }
}
