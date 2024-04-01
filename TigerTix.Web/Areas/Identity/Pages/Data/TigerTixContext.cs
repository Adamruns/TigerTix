using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TigerTix.Web.Data.Entities;
using TigerTix.Web.Models;
public class TigerTixContext : IdentityDbContext<AppUser>
{
    public DbSet<User> Users {get; set;}
    public DbSet<Event> Events { get; set; }
    public DbSet<Ticket> Tickets { get; set; }

    private readonly IConfiguration _config;

    public TigerTixContext (IConfiguration config)
    {
        _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
    }
}