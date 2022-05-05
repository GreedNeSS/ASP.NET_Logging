var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/", (ILogger<Program> logger, HttpContext context) =>
{
    logger.LogCritical($"Critical message {context.Request.Path}");
    logger.LogDebug($"Debug message {context.Request.Path}");
    logger.LogError($"Error message {context.Request.Path}");
    logger.LogInformation($"Information message {context.Request.Path}");
    logger.LogTrace($"Trace message {context.Request.Path}");
    logger.LogWarning($"Warning message {context.Request.Path}");
    return "Hello User";
});

app.Run();
