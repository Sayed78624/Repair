using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceBondhu.Models.Admin;

namespace ServiceBondhu.ViewModels
{
    public class MechanicVM
    {
        public int MechanicId { get; set; }
        public string MechanicName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int ServiceId { get; set; }
        //public bool IsAvailable { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public List<SelectListItem> ServiceList { get; set; } = new List<SelectListItem>();
    

    }
}
