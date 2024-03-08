using Microsoft.EntityFrameworkCore;
using TigerTix.Web.Data; // Ensure this using directive is correct

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TigerTixContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("YourConnectionStringName")));

builder.Services.AddControllers();

// Other service registrations...

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Other middleware configurations...

app.Run();