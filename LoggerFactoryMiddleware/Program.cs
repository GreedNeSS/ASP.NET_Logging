var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddDebug());
ILogger logger = loggerFactory.CreateLogger<Program>();

app.MapGet("/", () =>
{
    logger.LogInformation($"Path: /; Time: {DateTime.Now.ToLongTimeString()}");
    return "Main Page";
});
app.MapGet("/di", (ILoggerFactory logFartory) =>
{
    ILogger log = logFartory.CreateLogger<Program>();
    log.LogInformation($"Path: /di; Time: {DateTime.Now.ToLongTimeString()}");
    return "DI Page";
});

app.Run();
