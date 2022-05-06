using Microsoft.Extensions.Logging.Console;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();

builder.Services.AddLogging(builder =>
{
    builder.AddConsole();
    builder.AddFilter<ConsoleLoggerProvider>("Program", LogLevel.Trace);
});
var app = builder.Build();


app.Map("/", (ILogger<Program> logger) =>
{
    logger.LogCritical($"Critical message, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogDebug($"Debug message, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogError($"Error message, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogInformation($"Information message, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogTrace($"Trace message, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogWarning($"Warning message, Time: {DateTime.Now.ToLongTimeString()}");
    return "Hello User";
});

app.Run();