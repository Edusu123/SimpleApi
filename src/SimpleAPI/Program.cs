var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors();

var app = builder.Build();

app.MapControllers();

app.Run();
