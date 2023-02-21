using Microsoft.AspNetCore.Components;
using MyBlazorServerApp.Data;
using static MyBlazorServerApp.Data.WeatherForecastService;

namespace MyBlazorServerApp.Pages
{
    public class FetchDataBase : ComponentBase 
    {
        [Inject]
        protected IWeatherForecastService ForecastService { get; set; }

        protected WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
        }
    }
}
