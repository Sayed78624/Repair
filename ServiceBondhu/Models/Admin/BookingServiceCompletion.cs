using ServiceBondhu.Models.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceBondhu.Models.Admin
{
    public class BookingServiceCompletion
    {
        [Key]
        public int CompletionId { get; set; }
        [ForeignKey(nameof(Booking))]
        public int BookingId { get; set; }
        [ForeignKey(nameof(Mechanic))]
        public int MechanicId { get; set; }    // Which Mechanic completed it
        public DateTime CompletedAt { get; set; }
        public decimal ActualPrice { get; set; } // Final Cost decided by Mechanic
        public string? Remarks { get; set; }     // Optional comment

        public virtual Booking Booking { get; set; }
        public virtual Mechanic Mechanic { get; set; }
    }

}
