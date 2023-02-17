using NetCoreLinqToSqlInjection.Models;
using NetCoreLinqToSqlInjection.Repositories;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<IRepository, RepositoryDoctores>();
//builder.Services.AddTransient<IRepository, RepositoryDoctores>();
builder.Services.AddTransient<IRepository, RepositoryDoctoresOracle>();

// Add services to the container.
//builder.Services.AddTransient<Coche>();
//builder.Services.AddSingleton<Coche>();
builder.Services.AddSingleton<ICoche, Deportivo>();
//builder.Services.AddSingleton<ICoche, Deportivo>();
//builder.Services.AddSingleton<RepositoryDoctores>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
