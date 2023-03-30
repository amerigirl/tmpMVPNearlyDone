using Microsoft.EntityFrameworkCore;
using UserDAL.Models;

var builder = WebApplication.CreateBuilder(args);

//this will help it work for swagger
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CorsPolicy", builder =>
//    builder.AllowAnyOrigin()
//    .AllowAnyMethod()
//    .AllowAnyHeader());
//});
// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
    policy =>
    {
        policy.WithOrigins("https://localhost:4200",
     "http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddControllers();

string ConnectionStr = "Data Source= (localdb)\\Local; Initial Catalog=User; Integrated Security=True; TrustServerCertificate=True;";
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(ConnectionStr));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();

