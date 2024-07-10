using _21_MVC_RepositorySchool.Models;
using _21_MVC_RepositorySchool.Models.Context;
using _21_MVC_RepositorySchool.Models.SeedData;
using _21_MVC_RepositorySchool.Repository.Abstract;
using _21_MVC_RepositorySchool.Repository.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt =>
{

    opt.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));

});
builder.Services.AddScoped<IShcoolRepository, ShcoolRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IClassRoomRepository, ClassRoomRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
//builder.Services.AddTransient<IShcoolRepository<School>, ShcoolRepository>();
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

//SeedData.SeedDatas(app);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
