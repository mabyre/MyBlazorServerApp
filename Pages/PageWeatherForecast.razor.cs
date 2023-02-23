using Microsoft.AspNetCore.Components;
using MyBlazorServerApp.Data;

namespace MyBlazorServerApp.Pages;

public partial class PageWeatherForecast : ComponentBase
{
    [Inject]
    protected IWeatherForecastService ForecastService { get; set; }

    private WeatherForecast[] forecasts;
    private WeatherForecast currentForecast;
    private int index = 0;
    private int upperIndex = 0;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
        currentForecast = forecasts[index];
        upperIndex = forecasts.Count() - 1;
    }

    private async Task ChangeForecast(ChangeEventArgs e)
    {
        index = int.Parse(e.Value as string);
        if (index <= upperIndex && index >= 0)
        {
            currentForecast = forecasts[index];
        }
    }

}
