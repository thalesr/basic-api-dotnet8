using Microsoft.EntityFrameworkCore;
using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations;
using RestaurantManager.Database.Context;
using RestaurantManager.Database.UOW;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("RestaurantManagerDatabase");

//Database Layer
builder.Services.AddDbContext<RestaurantManagerDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>();

//Business Layer
builder.Services.AddSingleton<IAddressBusiness, AddressBusiness>();
builder.Services.AddSingleton<IDriverBusiness, DriverBusiness>();
builder.Services.AddSingleton<IMenuBusiness, MenuBusiness>();
builder.Services.AddSingleton<IOrderBusiness, OrderBusiness>();
builder.Services.AddSingleton<IPaymentBusiness, PaymentBusiness>();
builder.Services.AddSingleton<IRatingBusiness, RatingBusiness>();
builder.Services.AddSingleton<IRestaurantBusiness, RestaurantBusiness>();
builder.Services.AddSingleton<IUserBusiness, UserBusiness>();

// Add services to the container.

builder.Services.AddControllers();
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

app.Run();
