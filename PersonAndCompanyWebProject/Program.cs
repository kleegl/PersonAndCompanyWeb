using Microsoft.EntityFrameworkCore;
using PersonAndCompanyWebProject.Databases;
using PersonAndCompanyWebProject.Repositories.CompanyRepos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString: "DefaultConnection"));
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();
