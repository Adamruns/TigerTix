using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Venue { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        // Navigation property for related Tickets
        public virtual ICollection<Ticket> Tickets { get; set; }

        // You might also want to track the organizer or artist performing at the event
        [StringLength(100)]
        public string Organizer { get; set; }
        
        // Additional properties might include:
        // public string ImageUrl { get; set; }
        // public string Category { get; set; }
        // public int AvailableSeats { get; set; }
    }
}
