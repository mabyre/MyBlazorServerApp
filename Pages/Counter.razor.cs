using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace MyBlazorServerApp.Pages;

public class CounterBase : ComponentBase
{
    protected int currentCount = 0;

    [Parameter]
    public int ValueCounter { get; set; } = 2;

    [Inject]
    protected ILoggerFactory loggerFactory { get; set; }

    protected void IncrementCount()
    {
        currentCount += ValueCounter;

        var logger = loggerFactory.CreateLogger<CounterBase>();
        logger.LogWarning("Someone has clicked me!");

    }
}