using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace MyBlazorServerApp.Pages;

public partial class NavHandler : ComponentBase, IDisposable
{
    [Inject]
    NavigationManager Navigation { get; set; }

    private IDisposable? registration;

    private bool isPrevent = false;

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            registration =
                Navigation.RegisterLocationChangingHandler(OnLocationChanging);
        }
    }

    private ValueTask OnLocationChanging(LocationChangingContext context)
    {
        if (context.TargetLocation == "/counter")
        {
            context.PreventNavigation();
            isPrevent = true;
        }

        return ValueTask.CompletedTask;
    }

    public void Dispose() => registration?.Dispose();

}
