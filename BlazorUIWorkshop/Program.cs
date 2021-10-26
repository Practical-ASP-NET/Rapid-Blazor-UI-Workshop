using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorUIWorkshop;
using BlazorUIWorkshop.Exercises._6_Refit;
using Microsoft.Extensions.DependencyInjection;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<BlazorUIWorkshop.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRefitClient<IDonatelloApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://donatello-9hwr4.ondigitalocean.app/"));

await builder.Build().RunAsync();