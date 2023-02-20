using _11_DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

#region "Asp.Net Core Dependecny Injection"

// asp.net core ile birlikte built-in (dahili) dependecnt injection mod�l� geli�tirilmi�tir...ba��ml�kl�klar a�a��daki metotlar ile enjecte edilebilir;

// AddTransient
// AddScoped
// AddSingleton

// Yukar�daki metotlar ile instance olu�tulurur...
#endregion

//IMessage m = new MessageTR();
// instance register

// dependency injection uygulanmas�...
builder.Services.AddScoped<IMessage, MessageEng>();

// instance servisi aya�a kald�r�l�r...Asp.Net core'de instancelar services i�erisine eklenir...bu y�zden buradan enjecte edilen yap�lara servis denir...

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.UseEndpoints(endpoints =>
    endpoints.MapControllerRoute("default"
    , "{controller=home}/{action=index}")
);

app.Run();
