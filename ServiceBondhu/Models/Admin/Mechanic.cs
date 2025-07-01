using System.ComponentModel.DataAnnotations;

namespace ServiceBondhu.Models.Admin
{
    public class Mechanic
    {
        [Key]
        public int MechanicId { get; set; }
        public int UserId { get; set; }
        public int ExperienceYear { get; set; }
        public double Rating { get; set; }
        public string AvailableZone { get; set; }
        public bool IsAvailable { get; set; }

        //public virtual User User { get; set; }
        public IList<MechanicService> MechanicServices { get; set; } = new List<MechanicService>();
    }

}
