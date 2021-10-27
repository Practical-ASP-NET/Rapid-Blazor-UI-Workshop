using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RapidBlazorUI.Client;
using RapidBlazorUI.Client.Infrastructure;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRefitClient<IDonatelloApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://donatello-9hwr4.ondigitalocean.app/"));

await builder.Build().RunAsync();