
using Microsoft.EntityFrameworkCore;
using owmq_backend.Database;
using owmq_backend.Interfaces;
using owmq_backend.Services;

var builder = WebApplication.CreateBuilder(args);
// if backend opened on local host machine and not docker, add Local environment appsettings (assumes postgres lives on port 5432 and localhost)
builder.Configuration.AddJsonFile("appsettings.Local.json", optional: true);

// register custom services to handle logic for controllers
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IMapService, MapService>();

// database stuff
var connString = builder.Configuration.GetConnectionString("Default") ?? throw new InvalidOperationException("Connection String 'Default' not found...");
builder.Services.AddDbContext<owmqDbContext>(options => options.UseNpgsql(connString));

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()){
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
