using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceBondhu.Models.Admin
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [ForeignKey(nameof(ServiceCategory))]
        public int CategoryId { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set; }


        public virtual ServiceCategory ServiceCategory { get; set; }

    }
}
