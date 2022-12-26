using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Abstract.Bases;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using DataAccess.Repository.Bases;
using Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//string connectionString = builder.Configuration.GetConnectionString("CoreDB");
//builder.Services.AddDbContext<CoreContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddDbContext<CoreContext>();
builder.Services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<CoreContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IFeatureDal, EfFeatureDal>();
builder.Services.AddTransient<IAboutDal, EfAboutDal>();
builder.Services.AddTransient<IServiceDal, EfServiceDal>();
builder.Services.AddTransient<ISkillDal, EfSkillDal>();
builder.Services.AddTransient<IPortfolioDal, EfPortfolioDal>();
builder.Services.AddTransient<IExperienceDal, EfExperienceDal>();
builder.Services.AddTransient<IContactDal, EfContactDal>();
builder.Services.AddTransient<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddTransient<IMessageDal, EfMessageDal>();
builder.Services.AddTransient<IToDoListDal, EfToDoListDal>();

builder.Services.AddTransient<IFeatureService, FeatureManager>();
builder.Services.AddTransient<IAboutService, AboutManager>();
builder.Services.AddTransient<IServiceService, ServiceManager>();
builder.Services.AddTransient<ISkillService, SkillManager>();
builder.Services.AddTransient<IPortfolioService, PortfolioManager>();
builder.Services.AddTransient<IExperienceService, ExperienceManager>();
builder.Services.AddTransient<ITestimonialService, TestimonialsManager>();
builder.Services.AddTransient<IContactService, ContactManager>();
builder.Services.AddTransient<IMessageService, MessageManager>();
builder.Services.AddTransient<IToDoListService, ToDoListManager>();


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
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

//app.MapAreaControllerRoute(
//	name: "Writer",
//	areaName: "Writer",
//	pattern: "Writer/{controller=Home}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "areas",
		pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
	);
});

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
