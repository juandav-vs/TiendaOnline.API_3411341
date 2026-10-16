
using Microsoft.EntityFrameworkCore;
using TiendaOnline.API.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddDbContext<TiendaOnlineDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ConexionTienda")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirWasm", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("PermitirWasm");

app.UseAuthorization();

app.MapControllers();

app.Run();