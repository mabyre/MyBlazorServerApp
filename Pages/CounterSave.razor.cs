//
// User Data (counter's value) are saved form reloading page
//
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace MyBlazorServerApp.Pages;

public class CounterSaveBase : ComponentBase
{
    protected int currentCount = 0;

    private int valueCounter = 2;

    [Inject]
    private ProtectedSessionStorage ProtectedSessionStore { get; set; }


    protected async Task ButtonCounterOnClickAsync()
    {
        currentCount += valueCounter;
        await ProtectedSessionStore.SetAsync("count", currentCount);
    }

    protected override async Task OnInitializedAsync()
    {
        var result = await ProtectedSessionStore.GetAsync<int>("count");
        currentCount = result.Success ? result.Value : 0;
    }
}