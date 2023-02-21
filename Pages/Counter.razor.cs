using Microsoft.AspNetCore.Components;

namespace MyBlazorServerApp.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        [Parameter]
        public int ValueCounter { get; set; } = 2;

        protected void IncrementCount()
        {
            currentCount += ValueCounter;
        }
    }
}
