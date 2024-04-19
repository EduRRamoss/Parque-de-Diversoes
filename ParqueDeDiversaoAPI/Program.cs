using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using ParqueDeDiversaoAPI.ApplicationDbContext;
using ParqueDeDiversaoAPI.Interfaces;
using ParqueDeDiversaoAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Modificacoes parque
/*
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    }
);*/
builder.Services.AddDbContext<Context>(e => 
    e.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddCors();
//builder.Services.AddScoped(typeof(IGenericType<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(DbContext), typeof(Context));

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
