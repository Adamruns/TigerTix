using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddDbContext<TigerTixContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Server=tcp:tigertixserver.database.windows.net,1433;Initial Catalog=TigerTixApp.db;Persist Security Info=False;User ID=trulyhumbleundergod;Password=TigerTix$$;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")));


var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
// app.MapGet("/", () => "Hello World!");
app.UseDefaultFiles();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=App}/{action=Index}/{id?}");
app.Run();