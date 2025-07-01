using System.ComponentModel.DataAnnotations;

namespace ServiceBondhu.Models.Admin
{
    public class ServiceCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IList<Service> Services { get; set; } = new List<Service>();

    }
}
