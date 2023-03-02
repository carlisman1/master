var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//NECESITAMOS EL SERVICIO DE MEMORIA EN CACHE
builder.Services.AddDistributedMemoryCache();
//UN SESSION FUNCIONA POR TIEMPO DE INACTIVIDAD
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(5);
});


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

//IMPORTA EL ORDEN app.UseSession();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
