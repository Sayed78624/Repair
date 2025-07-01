using System.ComponentModel.DataAnnotations;

namespace ServiceBondhu.Models.Admin
{
    public class MechanicService
    {
        [Key]
        public int Id { get; set; }

        public int MechanicId { get; set; }
        public int ServiceId { get; set; }

        public virtual Mechanic Mechanic { get; set; }
        public virtual Service Service { get; set; }
    }

}
