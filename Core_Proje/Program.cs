using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Abstract.Bases;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using DataAccess.Repository.Bases;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




string connectionString = builder.Configuration.GetConnectionString("CoreDB");
builder.Services.AddDbContext<CoreContext>(options => options.UseSqlServer(connectionString));



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IFeatureDal, EFFeatureDal>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();
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
