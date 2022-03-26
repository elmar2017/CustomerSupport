using CustomerSupport.BLL.Abstract;
using CustomerSupport.BLL.Concrete;
using CustomerSupport.DAL.Abstract;
using CustomerSupport.DAL.Concrete;
using CustomerSupport.DAL.Models;
using CustomerSupport.Extensions;
using CustomerSupport.Models.Validators;
using FluentValidation.AspNetCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, config) =>
{
    config.ReadFrom.Configuration(context.Configuration);
});

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<EnquireValidator>()); ;
builder.Services.AddFluentValidation();
builder.Services.AddScoped<IRepository<BaseEntity>, Repository<BaseEntity>>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEnquireService, EnquireService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSingleton<VirtualDb<BaseEntity>>();

var app = builder.Build();

app.UseExceptionHandlerMiddleware();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Create}/{id?}");

app.Run();
