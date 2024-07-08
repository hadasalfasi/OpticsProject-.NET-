using Microsoft.EntityFrameworkCore;
using Models.Models;

var builder = WebApplication.CreateBuilder();
//args
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//connection string
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CustomerContext>(options =>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultDataBase")));
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

app.Run();
