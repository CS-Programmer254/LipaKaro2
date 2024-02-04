
using AbsaBank.Microservice.Application.Commands;
using AbsaBank.Microservice.Application.Services;
using AbsaBank.Microservice.Domain.Entities;
using AbsaBank.Microservice.Domain.Repositories;
using AbsaBank.Microservice.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AbsaCoreBanking");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AbsaBankDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IStudentAccountService, StudentAccountService>();
builder.Services.AddScoped<IStudentAccountRepository, StudentAccountRepository>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(CreateStudentAccountCommandHandler)));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(DeleteStudentAccountCommandHandler)));


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
