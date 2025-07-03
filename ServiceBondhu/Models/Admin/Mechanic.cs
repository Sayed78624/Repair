using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ServiceBondhu.Models.Admin
{
    public class Mechanic
    {
        [Key]
        public int MechanicId { get; set; }
        public string MechanicName {  get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public bool IsAvailable { get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }
    }

}

