using FizzBuzz.Web.Components;
using FizzBuzz.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<IFizzBuzzService, FizzBuzzService>()
    .AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
