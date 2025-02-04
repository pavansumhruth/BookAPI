using BookAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure MySQL Database
builder.Services.AddDbContext<BookDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 32))));

var app = builder.Build();
app.MapGet("/", () => "Hello, World!");

app.UseAuthorization();
app.MapControllers();
app.Run();
