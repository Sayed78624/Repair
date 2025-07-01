using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ServiceBondhu.Models.Admin;

namespace ServiceBondhu.Models.User
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        [ForeignKey(nameof(BookingServiceCompletion))]
        public int CompletionId { get; set; }

        public DateTime BookingDate { get; set; }
        public DateOnly ServiceDate { get; set; }
        public TimeSpan ServiceTime { get; set; }

        public bool IsApprove { get; set; }   // Admin approval
        public bool IsServiceCompleted { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Service Service { get; set; }

    }


}
