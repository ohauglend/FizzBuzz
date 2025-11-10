using FizzBuzz.Web.Components;
using FizzBuzz.Web.Interfaces;
using FizzBuzz.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<IFizzBuzzService, FizzBuzzService>()
    .AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
