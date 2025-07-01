using System.ComponentModel.DataAnnotations;

namespace ServiceBondhu.Models.Admin
{
    public class ActionType
    {
        [Key]
        public int ActionId { get; set; }
        public string ActionName { get; set; } // Approve, PriceEntry
    }
}
