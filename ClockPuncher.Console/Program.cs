using ClockPuncher.Application;
using ClockPuncher.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

//setup our DI
var serviceProvider = new ServiceCollection()
    .AddLogging()
    .AddSingleton<ITimeCard, TimeCard>()
    .AddLogging((loggingBuilder) => loggingBuilder
        .SetMinimumLevel(LogLevel.Trace)
        .AddConsole()
        )
    .BuildServiceProvider();

var loggerFactory = serviceProvider.GetService<ILoggerFactory>();

var logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("Starting application");

//do the actual work here
var timeCard = serviceProvider.GetService<ITimeCard>();

if (timeCard is null) return;

try
{
    timeCard.Punch();

    Thread.Sleep(1000);
    timeCard.Punch();

    Thread.Sleep(2000);
    timeCard.Punch();

    Thread.Sleep(3000);
    timeCard.Punch();

    Thread.Sleep(5000);
    timeCard.Punch();

    Thread.Sleep(8000);
    timeCard.Punch();

    timeCard.GetPunchState();

    timeCard.GetTotalAttendance();

}
catch (Exception e)
{
    logger.LogError(e, e.Message);
}
logger.LogInformation("All done!");

loggerFactory.Dispose();
Console.WriteLine("Press any key to continue!");
Console.ReadKey();


