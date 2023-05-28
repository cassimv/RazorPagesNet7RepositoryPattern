using BusinessLogic.StaticMappings;
using BusinessLogic.StudentBusiness;
using DataLogic;
using DataLogic.LogicInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.ImplementedRepositories;
using Repository.RepositoryInterfaces;

void SetupInjectionDependency(WebApplicationBuilder webApplicationBuilder)
{
    //Define the repositories that will be injected into the necessary controllers/pages
    webApplicationBuilder.Services.AddTransient<iStudentRepository, StudentRepository>();
    webApplicationBuilder.Services.AddTransient<IStudentLogic, StudentLogic>();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<DefaultContext>(
    options => options.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString")));

SetupInjectionDependency(builder);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
