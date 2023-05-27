using ControlExpenses.Application.Behavior;
using ControlExpenses.CrossCutting.Interfaces;
using ControlExpenses.CrossCutting.Models;
using ControlExpenses.Data.Context;
using ControlExpenses.Data.Repositories;
using ControlExpenses.Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//                .AddEntityFrameworkStores<ControlExpenseContext>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(ControlExpenses.Application.AssemblyReference.Assembly));

builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<ICommandBus, CommandBus>();

builder.Services
       .AddDbContext<ControlExpenseContext>(
            option => option.UseSqlServer(builder.Configuration.GetConnectionString("ControlExpenseContext"))
       );

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
