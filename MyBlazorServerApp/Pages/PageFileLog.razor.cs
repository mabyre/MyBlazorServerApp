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

        protected string logFileToDisplay = "Here will take place file log content.";

        protected void ButtonMakeLogs_OnClick()
        {
            logger.LogTrace("Trace");
            logger.LogInformation("Information");
        }

        protected void ButtonDisplayLogs_OnClick()
        {
            string fileName = FileLogger.Logging.FileLoggerProvider.PathFileName;
            logFileToDisplay = File.ReadAllText(fileName);
        }

    }
}
