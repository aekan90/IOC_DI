using IOC_DI.Web.Models.Services.Abstract;
using IOC_DI.Web.Models.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ISingletonDateService, DateService>(); // her requeste 1 nesne örneði
builder.Services.AddScoped<ISingletonDateService, DateService>();  // her requeste yeni 1 nesne örneði
builder.Services.AddTransient<ISingletonDateService, DateService>(); // her requestteki her isteðe 1 nesne örneði

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
