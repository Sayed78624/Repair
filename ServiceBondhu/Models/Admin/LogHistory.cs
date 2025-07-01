using ServiceBondhu.Models.User;
using System.ComponentModel.DataAnnotations;

namespace ServiceBondhu.Models.Admin
{
    public class LogHistory
    {
        [Key]
         public int LogId { get; set; }
         public int BookingId { get; set; }         // Who Booking
         public int? UserId { get; set; }           // Who Provide Servce(Mechanic,Service Provider)
         public int ActionId { get; set; }     //User Action krbe like Approve Booking, PriceEntry after completing service, 
         public string? Remarks { get; set; }       // Optional Comments
         public DateTime ActionTime { get; set; }   // When entry Action like Approved Booking, EntryPrice
        public decimal? ActualPrice { get; set; }

        //public virtual Users? User { get; set; }    //Who doing action
        public virtual Booking Booking { get; set; }
         public virtual ActionType ActionType { get; set; }    
     }

}

