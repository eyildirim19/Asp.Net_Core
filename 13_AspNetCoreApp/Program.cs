using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddJsonOptions(c =>
{
    c.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddDbContext<NorthwindContext>(options =>
{
    //options.UseSqlServer("Server=.; Database=Northwind;uid=sa;pwd=123;TrustServerCertificate=true");
    options.UseSqlServer(builder.Configuration.GetConnectionString("myCon"));
});

var app = builder.Build();
//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.MapControllerRoute("default",
    "{controller=home}/{action=index}");

app.Run();
