using BitBasket.API;
using BitBasket.Core;
using BitBasket.Core.Mappers;
using BitBasket.Infrastructure;
using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Add Services

builder.Services.AddInfrastructureServices();
builder.Services.AddCoreServices();
builder.Services.AddAuthorization();
builder.Services.AddControllers()
    .AddJsonOptions(options =>  
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => builder
    .WithOrigins("http://localhost:4132")
    .AllowAnyHeader()
    .AllowAnyMethod()
    );
});

builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);

builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();

app.UseSwaggerUI();

app.UseCors();

app.Run();