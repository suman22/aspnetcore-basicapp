using App.Movie;
using Microsoft.EntityFrameworkCore;
using MovieApplication.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder
    .Configuration.GetConnectionString("MovieConnection")));

builder.Services.AddScoped<DbContext,ApplicationDbContext>();

builder.Services.AddMovieServiceConfiguration();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Actor}/{action=Index}/{id?}",
    defaults: new {controller="Actor",Action="Index"}
    );

app.Run();
