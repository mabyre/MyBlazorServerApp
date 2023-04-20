using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Tools.Logger;

namespace MyBlazorServerApp.Pages;

public class CounterBase : ComponentBase
{
    protected int currentCount = 0;

    public int valueCounter = 2;

    [Inject]
    protected ILoggerFactory loggerFactory { get; set; }

    private ILogger<CounterBase> logger => loggerFactory.CreateLogger<CounterBase>();

    private string message = "Initial assigned message.";

    Tools.Logger.FileLogger file = new Tools.Logger.FileLogger("Log.txt");

    protected override void OnInitialized()
    {
        Logger.WriteMessage += LoggingMethods.LogToConsole;
        Logger.WriteMessage += LoggingMethods.LogToTrace;
        Logger.LogLevel = Severity.Verbose; // by default set to Warning
    }

    protected void OnClickButtonCounter()
    {
        currentCount += valueCounter;
        logger.LogWarning("Someone has clicked me!");
    }

    protected void OnClickButtonLog()
    {
        currentCount += valueCounter;
        logger.LogWarning("Someone has clicked me!");

        Logger.LogMessage(Severity.Verbose, "UserControl1", "Click on Trace");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        logger.LogInformation("OnAfterRender(1): firstRender: " +
            "{FirstRender}, message: {Message}", firstRender, message);

        if (firstRender)
        {
            message = "Executed for the first render.";
        }
        else
        {
            message = "Executed after the first render.";
        }

        logger.LogInformation("OnAfterRender(2): firstRender: " +
            "{FirstRender}, message: {Message}", firstRender, message);
    }

}