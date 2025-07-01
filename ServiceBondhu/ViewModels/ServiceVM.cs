using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceBondhu.ViewModels
{
    public class ServiceVM
    {
        public int ServiceId { get; set; }
        public int CategoryId { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set; }

        public string CategoryName { get; set; } = string.Empty;
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}
