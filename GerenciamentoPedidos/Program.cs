using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GerenciamentoPedidos;
using GerenciamentoPedidos.Services;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Injeção dos seus serviços em memória
builder.Services.AddSingleton<ClienteService>();
builder.Services.AddSingleton<ProdutoService>();
builder.Services.AddSingleton<PedidoService>();
builder.Services.AddSingleton<NotificationService>();

// Se futuramente for chamar APIs HTTP:
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
