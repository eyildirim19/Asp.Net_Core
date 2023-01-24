var builder = WebApplication.CreateBuilder(args);


// servis
builder.Services.AddControllersWithViews(); // Controller servisi container'a eklenir...

var app = builder.Build();

app.UseStaticFiles();

// Middleware 
app.UseRouting(); // Rota ��z�mlenir

app.MapGet("/Product", () => "Hello World!");
app.MapControllerRoute( // rota e�le�tirilir...
    "Default",// 
    "{controller=Home}/{action=Index}"
    );

app.Run();


// Controller/Action
//Route
//Home/Index
//Product/Index