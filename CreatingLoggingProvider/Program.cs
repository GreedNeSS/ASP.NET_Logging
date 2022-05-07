using CreatingLoggingProvider.FileLogger;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "Logger.txt"));
var app = builder.Build();

app.MapGet("/", (ILogger<Program> logger, HttpContext context) =>
{
    logger.LogInformation($"Path: {context.Request.Path}; Time: {DateTime.Now.ToLongTimeString()}");
    return "Hellp User!";
});

app.Run();
