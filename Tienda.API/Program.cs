using Microsoft.EntityFrameworkCore;
using Tienda.Infrastructure;
using Tienda.Application.Interfaces;
using Tienda.Infrastructure.Services;
using Tienda.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar DbContext con conexión a PostgreSQL
builder.Services.AddDbContext<TiendaDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar servicios de aplicación
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

// Agregar servicios de Swagger y controladores
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Ahora sí, construir la app
var app = builder.Build();

// Middleware para Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
