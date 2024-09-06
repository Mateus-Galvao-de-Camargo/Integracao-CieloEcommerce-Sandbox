using Microsoft.EntityFrameworkCore;
using TesteDaUmbler.Components;
using TesteDaUmbler.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

// Adicionar servi�os ao cont�iner
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(x => x.UseInMemoryDatabase("app"));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Adicionar o CieloService
builder.Services.AddHttpClient<CieloService>();

builder
    .Services
    .AddHttpClient("MyAPI", client => { client.BaseAddress = new Uri("https://localhost:5035/");})
    .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
    {
        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
    });

var app = builder.Build();

// Testar MakePayment quando o sistema iniciar
//using (var scope = app.Services.CreateScope())
//{
//    var cieloService = scope.ServiceProvider.GetRequiredService<CieloService>();

//    try
//    {
//        // Chama o m�todo CreatePayment e exibe o resultado no console
//        var paymentResult = await cieloService.CreatePayment();
//        Console.WriteLine($"Resultado do pagamento: {paymentResult}");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Erro ao processar o pagamento: {ex.Message}");
//    }
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
