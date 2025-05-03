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

builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);

builder.Services.AddFluentValidationAutoValidation();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();