using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBlazorServerApp.Pages
{
    public partial class PageFileLog : ComponentBase
    {
        [Inject]
        private ILoggerFactory loggerFactory { get; set; }

        private ILogger<PageFileLog> logger => loggerFactory.CreateLogger<PageFileLog>();

        protected void ButtonMakeLogs_OnClick()
        {
            logger.LogTrace("Trace in page");
        }

        protected void ButtonDisplayLogs_OnClick()
        {
        }

    }
}
