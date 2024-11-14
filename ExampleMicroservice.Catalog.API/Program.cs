using ExampleMicroservice.Catalog.API.Options;
using ExampleMicroservice.Catalog.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOptionsExt();
builder.Services.AddDatabaseServices();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();