using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Data; // Ensure this using statement is correct for accessing your context

namespace TigerTix.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly TigerTixContext _context;

        public HomeController(TigerTixContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // If you want to pass events data to the Events/Index view, fetch it here
            var events = _context.Events.ToList();
            // Then, return the Events/Index view directly, optionally passing the events data
            return View("~/Views/Events/Index.cshtml", events);
        }
    }
}
