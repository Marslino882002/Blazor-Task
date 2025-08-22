using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor.Client;
using Blazor.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<StudentService>();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://blazor123.runasp.net/")
});

await builder.Build().RunAsync();
