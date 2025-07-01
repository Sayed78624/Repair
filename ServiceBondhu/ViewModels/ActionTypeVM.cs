using System.ComponentModel.DataAnnotations;

namespace ServiceBondhu.ViewModels
{
    public class ActionTypeVM
    {
        [Key]
        public int ActionId { get; set; }
        public string ActionName { get; set; }
    }
}
