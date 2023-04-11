using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PharmacyDBMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// get connection string
var connectionString = builder.Configuration.GetConnectionString("PharmacyDatabase");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// create the database context
builder.Services.AddDbContextFactory<PharmacyContext>(options => options.UseSqlite(connectionString));

// allowing ProductServices to be accessed by the front end
builder.Services.AddTransient<PharmacyDBMS.Services.ProductServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
