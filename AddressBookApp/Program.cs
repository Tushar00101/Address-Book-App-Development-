using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Database connection
var connectionString = builder.Configuration.GetConnectionString("SqlConnections");
builder.Services.AddDbContext<BookContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
