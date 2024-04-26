using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPost("/", ([FromForm] string id) => Results.Ok())
    .DisableAntiforgery();

app.Run();