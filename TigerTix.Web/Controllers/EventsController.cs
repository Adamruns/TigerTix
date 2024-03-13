using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;


namespace TigerTix.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventsController : Controller
    {
        private readonly TigerTixContext _context;

        public EventsController(TigerTixContext context)
        {
            _context = context;
        }

        // GET: events
        [HttpGet]
        public IActionResult GetAllEvents()
        {
            var events = _context.Events.ToList();
            return View("Index", events);
        }

        // GET: events/:id
        [HttpGet("{id}")]
        public IActionResult GetEventById(int id)
        {
            var eventItem = _context.Events
                .FirstOrDefault(e => e.Id == id);

            if (eventItem == null)
            {
                return NotFound();
            }

            return Ok(eventItem);
        }

        // POST: events
        [HttpPost]
        public IActionResult CreateNewEvent([FromBody] Event eventModel)
        {
            // logic to create a new event
            return CreatedAtAction(nameof(GetEventById), new { id = eventModel.Id }, eventModel);
        }

        // PUT: events/:id
        [HttpPut("{id}")]
        public IActionResult UpdateEvent(int id, [FromBody] Event eventModel)
        {
            // logic to update an existing event
            return NoContent();
        }

        // DELETE: events/:id
        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            // logic to delete an event
            return NoContent();
        }
    }
}
