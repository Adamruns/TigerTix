using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Data;
using TigerTix.Web.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TigerTix.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : Controller
    {
        private readonly TigerTixContext _context;

        public TicketsController(TigerTixContext context)
        {
            _context = context;
        }

        // // POST: api/tickets/purchase
        // [HttpPost("purchase")]
        // public IActionResult PurchaseTicket([FromBody] TicketPurchaseDTO purchaseDto)
        // {
        //     // Logic to purchase a ticket, probably including user and event verification, 
        //     // payment processing, and generating a unique TicketCode.
        //     // This is just a placeholder logic.
        //     var ticket = new Ticket
        //     {
        //         EventId = purchaseDto.EventId,
        //         UserId = purchaseDto.UserId,
        //         PurchaseDate = DateTime.UtcNow,
        //         TicketCode = Guid.NewGuid().ToString(), // Example of generating a unique code
        //         Price = purchaseDto.Price,
        //         Status = "active"
        //     };

        //     _context.Tickets.Add(ticket);
        //     _context.SaveChanges();

        //     return CreatedAtAction(nameof(GetTicketById), new { ticketId = ticket.TicketId }, ticket);
        // }

        // GET: api/tickets/user/:userID
        [HttpGet("user/{userId}")]
        public IActionResult GetTicketsForUser(int userId)
        {
            var tickets = _context.Tickets
                .Where(t => t.UserId == userId)
                .ToList();

            return Ok(tickets);
        }

        // GET: api/tickets/:ticketId
        [HttpGet("{ticketId}")]
        public IActionResult GetTicketById(int ticketId)
        {
            var ticket = _context.Tickets
                .Include(t => t.Event) // Include the Event details in the response
                .FirstOrDefault(t => t.TicketId == ticketId);

            if (ticket == null)
            {
                return NotFound();
            }

            return Ok(ticket);
        }

        // Additional actions like Update or Cancel can be added here
    }
}
