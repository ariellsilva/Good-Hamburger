using GoodHamburger.Controllers;
using GoodHamburger.Models;

var builder = WebApplication.CreateBuilder(args);

// Estas linhas dão vida aos seus Controllers
builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers(); // Importante para achar o PedidosController

app.Run();