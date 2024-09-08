using Microsoft.EntityFrameworkCore;
using TesteDaUmbler.Components;
using TesteDaUmbler.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(x => x.UseInMemoryDatabase("app"));
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Adicionar CieloService com HttpClient
builder.Services.AddHttpClient<CieloService>();

builder.Services.AddControllers();
builder.Services.AddAntiforgery();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

#pragma warning disable ASP0014 // Suggest using top level route registrations
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

    endpoints.MapControllers();
});
#pragma warning restore ASP0014 // Suggest using top level route registrations

app.Run();
