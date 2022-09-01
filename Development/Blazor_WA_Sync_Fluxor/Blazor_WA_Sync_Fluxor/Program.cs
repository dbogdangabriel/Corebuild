using Blazor_WA_Sync_Fluxor;
using Blazor_WA_Sync_Fluxor.State.Weather;
using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

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

builder.Services.AddScoped<WeatherDataState>();
await builder.Build().RunAsync();
