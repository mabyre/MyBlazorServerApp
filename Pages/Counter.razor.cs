using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace MyBlazorServerApp.Pages;

public class CounterBase : ComponentBase
{
    protected int currentCount = 0;

    public int valueCounter = 2;

    [Inject]
    protected ILoggerFactory loggerFactory { get; set; }

    private ILogger<CounterBase> logger => loggerFactory.CreateLogger<CounterBase>();

    private string message = "Initial assigned message.";

    protected void ButtonCounterOnClick()
    {
        currentCount += valueCounter;
        logger.LogWarning("Someone has clicked me!");
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