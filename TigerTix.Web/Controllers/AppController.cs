using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Data;

public class AppController : Controller
{
    private readonly TigerTixContext _context;

    public AppController(TigerTixContext context)
    {
        _context = context;
    }

    public IActionResult ShowUsers()
    {
        //LINQ Query
        var results = from u in _context.Users
                select u;
        return View(results.ToList());
    }
}
