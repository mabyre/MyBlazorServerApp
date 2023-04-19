using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.Extensions.Logging;

namespace MyBlazorServerApp.Pages;

public partial class Navigate : ComponentBase, IDisposable
{
    [Inject]
    NavigationManager Navigation { get; set; }

    [Inject]
    ILogger<Navigate> Logger { get; set; }

    private void NavigateToCounterComponent()
    {
        Navigation.NavigateTo("counter");
    }

    protected override void OnInitialized()
    {
        Navigation.LocationChanged += HandleLocationChanged;
    }

    private void HandleLocationChanged(object? sender, LocationChangedEventArgs e)
    {
        Logger.LogInformation("URL of new location: {Location}", e.Location);
    }

    public void Dispose()
    {
        Navigation.LocationChanged -= HandleLocationChanged;
    }
}
