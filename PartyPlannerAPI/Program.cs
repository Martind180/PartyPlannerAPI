global using FastEndpoints;
global using FluentValidation;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using PartyPlannerAPI.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();

builder.Services.AddDbContext<PartyPlannerDbContext>(options =>
{
    options.UseSqlite("Data Source=PartyPlanner.db");
});

var app = builder.Build();

app.UseFastEndpoints();
app.UseSwaggerGen();

app.Run();