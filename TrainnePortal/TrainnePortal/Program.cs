using Microsoft.EntityFrameworkCore;
using trainneportal.models.services;
using TrainnePortal.Models.Services;
using TrainnePortal.Models.User;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("conn");
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer(connection);});
builder.Services.AddScoped<Icrud, Regdetails>();


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
    pattern: "{controller=Home}/{action=Admin}/{id?}");
app.Run();
