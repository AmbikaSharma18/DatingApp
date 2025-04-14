using DatingApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200", "https://localhost:4200"));	

app.MapControllers();

app.Run();


/*
What is Dependency Injection?
Dependency Injection (DI) is a design pattern used to manage dependencies in your application. Simply put, it’s a way of passing objects or services that a class needs (its dependencies) from the outside, rather than letting the class create them itself.

This helps to loosen the coupling between different parts of your application, making it easier to manage, test, and maintain.

Builder - a Builder is a design pattern used to construct complex objects step by step. It helps to create objects with many possible configurations and ensures that an object is created in a particular state by the time it's fully built.
*/