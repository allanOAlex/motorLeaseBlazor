using BlazorStrap;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ML.Client;
using ML.Client.Services.Users;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<NotificationService>();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorStrap();

await builder.Build().RunAsync();

//void AddForwardHeaders(app)
//{
//    var forwardingOptions = new ForwardedHeadersOptions()
//    {
//        ForwardedHeaders = ForwardedHeaders.All
//    };
//    forwardingOptions.KnownNetworks.Clear();
//    forwardingOptions.KnownProxies.Clear();
//    app.UseForwardedHeaders(forwardingOptions);
//}