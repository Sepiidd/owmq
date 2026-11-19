using Microsoft.EntityFrameworkCore;
using owmq_backend.Database;
using helpers.Images;

//idempotent: read and add all images from local images directory to postgres db
ImagesInit initializer = new ImagesInit();
initializer.readImages();

var builder = WebApplication.CreateBuilder(args);
// if backend opened on local host machine and not docker, add Local environment appsettings (assumes postgres lives on port 5432 and localhost)
builder.Configuration.AddJsonFile("appsettings.Local.json", optional: true);

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
