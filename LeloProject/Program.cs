using LeloProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Add services to the container.


builder.Services.AddDbContext<AppDbContext>(options =>
                   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddScoped<IPasswordValidator<IdentityUser>>();
//builder.Services.AddScoped<IUserValidator<IdentityUser>>();

//builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
builder.Services.AddScoped<IClaimRepository, ClaimRepository>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(opts => {
    opts.Password.RequireUppercase = false;
    opts.Password.RequiredLength = 5;
    opts.User.RequireUniqueEmail = true;
    opts.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<AppDbContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapDefaultControllerRoute();
app.Run();
