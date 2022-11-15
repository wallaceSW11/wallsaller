using MediatR;
using Backend.Application.Service;
using Backend.Domain.Interfaces;
using Backend.Infra.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IClientRepository, ClientRepository>();
builder.Services.AddSingleton<ClientService>();
builder.Services.AddMediatR(AppDomain.CurrentDomain.Load("Backend.Application"));


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
