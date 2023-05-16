using AspDotNetCoreEvi.Models;
using AspDotNetCoreEvi.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer("name=ConnectionStrings:ProductDBCon"));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
