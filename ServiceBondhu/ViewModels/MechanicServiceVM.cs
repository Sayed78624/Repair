using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceBondhu.ViewModels
{
    public class MechanicServiceVM
    {
        public int MechanicServiceId { get; set; }
        public int MechanicId { get; set; }
        public int ServiceId { get; set; }
    }
}
