using Microsoft.EntityFrameworkCore;
using SignalR.Models;
using SignalR.MyHub;
using SignalR.repos;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
//builder.Services.AddDbContext<CompanyEntity>(n => n.UseSqlServer(builder.Configuration.GetConnectionString("iticon")));

builder.Services.AddDbContext<CompanyEntity>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
});
//inject repos 
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.MapHub<EmployeeHub>("/EmpHub");
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employees}/{action=Index}/{id?}");

app.Run();
