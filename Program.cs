var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/wellcome", () => "Hello World!");

app.Run();
