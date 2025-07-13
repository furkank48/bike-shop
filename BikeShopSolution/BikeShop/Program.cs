using BikeShop.Application;
using BikeShop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// DI (Dependency Injection) – Repository’i baðlama
builder.Services.AddSingleton<IProductRepository, ProductRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

