using LaborExchange.Frontend.Clients;
using LaborExchange.Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var LaborExchange = builder.Configuration["LaborExchangeUrl"] ?? throw new Exception("LaborExchange URL is not set");
// var LaborExchange = "http://localhost:5104";

builder.Services.AddHttpClient<VacanciesClient>(client => client.BaseAddress = new Uri(LaborExchange));
builder.Services.AddHttpClient<ProfessionsClient>(client => client.BaseAddress = new Uri(LaborExchange));
builder.Services.AddHttpClient<ResumeClient>(client => client.BaseAddress = new Uri(LaborExchange));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
