using ControlExpenses.Data.Context;
using ControlExpenses.Data.Repositories;
using ControlExpenses.Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services
       .AddDbContext<ControlExpenseContext>(
            option => option.UseSqlServer(builder.Configuration.GetConnectionString("ControlExpenseContext"))
       );

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddMediatR(typeof(Program));

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
