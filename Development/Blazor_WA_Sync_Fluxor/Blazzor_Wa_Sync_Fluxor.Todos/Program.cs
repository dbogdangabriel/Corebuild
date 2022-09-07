using Blazzor_Wa_Sync_Fluxor.Todos;
using Blazzor_Wa_Sync_Fluxor.Todos.Services;
using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using System.Net.Mime;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// Add custom application services
builder.Services.AddScoped<StateFacade>();
builder.Services.AddHttpClient<JsonPlaceholderApiService>(client =>
{
    client.DefaultRequestHeaders.Add("Content-Control", $"{MediaTypeNames.Application.Json}; charset=utf-8");
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
});

builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzAzMTM3QDMyMzAyZTMyMmUzMGVMZW1hT2Q0MkFwQ3dtQWZORlFlZjJTYVNZZTJJN3FsbE9yZUdBREJ0blE9");

builder.Services.AddFluxor(o =>
{
    o.ScanAssemblies(typeof(Program).Assembly);
    o.UseReduxDevTools(rdt =>
    {
        rdt.Name = "My Blazor application";
    });
});

await builder.Build().RunAsync();
