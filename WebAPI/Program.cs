using Microsoft.Net.Http.Headers;
using PluginManager;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.LoadPluginSystem();

builder.Services.AddCors(options => options.AddPolicy(
    name: "CORS",
    policy => policy.WithOrigins(
            "http://localhost:3000",
            "https://localhost:3000")
        .WithHeaders(
            HeaderNames.ContentType,
            HeaderNames.AccessControlAllowCredentials,
            HeaderNames.AccessControlAllowHeaders,
            HeaderNames.XRequestedWith,
            HeaderNames.AccessControlAllowOrigin,
            "X-SignalR-User-Agent",
            "Authorization")
        .WithMethods(
            "GET", 
            "POST")
        .AllowCredentials()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CORS");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();