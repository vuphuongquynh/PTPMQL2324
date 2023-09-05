using demoMVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//set connect to database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

//Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeLine
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // the defau HSTS value is 30 days.
     app.UseHsts();
}