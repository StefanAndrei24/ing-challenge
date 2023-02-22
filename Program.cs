using Bank.configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSystemServices(builder.Configuration);

var app = builder.Build();

app.AddConfiguration(app.Environment);

app.Run();
