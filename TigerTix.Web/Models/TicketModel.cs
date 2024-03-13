using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TigerTix.Web.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        // Foreign key reference to the Event model
        [Required]
        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }

        // Assuming each user has a unique UserId
        [Required]
        public int UserId { get; set; }

        public DateTime PurchaseDate { get; set; }

        // Unique identifier for the ticket (e.g., barcode, QR code)
        public string TicketCode { get; set; }

        // Seating information
        public string SeatNumber { get; set; }

        // The price at which the ticket was sold
        public decimal Price { get; set; }

        // Ticket status (e.g., active, used, cancelled)
        public string Status { get; set; }

        // Additional properties might include:
        // public DateTime EventDate { get; set; }
        // public string Venue { get; set; }
        // Navigation property for a user if you have a User model
        // public virtual User User { get; set; }
    }
}
