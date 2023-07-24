using Microsoft.EntityFrameworkCore;
using P330Pronia.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options=>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
         name: "areas",
         pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
       );
app.MapControllerRoute(
    name: "defoult",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
    );


app.Run();
