var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/", (ILogger<Program> logger, HttpContext context) =>
{
    logger.LogCritical($"Critical message {context.Request.Path}, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogDebug($"Debug message {context.Request.Path}, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogError($"Error message {context.Request.Path}, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogInformation($"Information message {context.Request.Path}, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogTrace($"Trace message {context.Request.Path}, Time: {DateTime.Now.ToLongTimeString()}");
    logger.LogWarning($"Warning message {context.Request.Path}, Time: {DateTime.Now.ToLongTimeString()}");
    return "Hello User";
});

app.Run();