using Microsoft.EntityFrameworkCore;
using Newswebsite.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(); // Use Razor Pages

builder.Services.AddDbContext<NewsWebsiteContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Serve static files

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages(); // Map Razor Pages endpoints

// If you want to keep MVC controllers as well, you can also include:
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<NewsWebsiteContext>();
    DbInitializer.Seed(dbContext);
}

app.Run();
namespace Newswebsite.services
{
    //your services go here
}
