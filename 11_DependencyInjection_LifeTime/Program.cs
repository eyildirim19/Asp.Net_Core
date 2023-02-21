using _11_DependencyInjection_LifeTime.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


// AddTransient => s�rekli yeni instance olu�turur
builder.Services.AddTransient<MyClass>();

// AddScoped =>ge�erli request i�in instance olu�turur...
//builder.Services.AddScoped<MyClass>();

// AddSingleton => uygulaman�n ya�am s�reci boyunca tek bir instance olu�turur. �ok dikkatli kullan�lmas� gerekir...
//builder.Services.AddSingleton<MyClass>();


var app = builder.Build();

app.MapControllerRoute("default",
    "{controller=home}/{action=index}");

app.Run();
