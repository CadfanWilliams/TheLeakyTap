using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace TheLeakyTap.Models
{
	public class Booking
	{
		public Booking()
		{
		}

		[Required]
		[DisplayName("Booking Reference")]
		public int bookingID { get; set; }
        [Required]
        [DisplayName("Name")]
        public string bookingName { get; set; }
        [Required]
        [DisplayName("Booking Type")]
        public string bookingType { get; set; }
        [Required]
        [DisplayName("Booking Date and Time")]
        public DateTime bookingDate { get; set; }
		[Required]
        [DisplayName("Number of Guests")]
        public int bookingGuests { get; set; }
        [DisplayName("Booking Notes")]
        public string bookingNotes { get; set; }

    }
}

