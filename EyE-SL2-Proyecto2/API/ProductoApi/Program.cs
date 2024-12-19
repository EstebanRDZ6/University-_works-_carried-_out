using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ProductoApi.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp", policy =>
    {
        // Permitir solicitudes desde el frontend en https://localhost:7053/
        policy.WithOrigins("https://localhost:7053") // URL de la frontend
              .AllowAnyHeader()  // Permite cualquier cabecera
              .AllowAnyMethod(); // Nos permite los metodos CRUD.
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductosDb")));


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowBlazorApp");  

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
