using BL;
using DAL.Data;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Models.Models;

var builder = WebApplication.CreateBuilder(args);
//
// Add services to the container.
string myCors = "_myCors";
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(op =>
{
    op.AddPolicy(myCors,
        builder =>
        {
            builder.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});


//connection string
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CustomerContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultDataBase")));
builder.Services.AddScoped<ICustomer, CustumerData>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(myCors);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<IdValidationMiddleware>();


app.Run();
