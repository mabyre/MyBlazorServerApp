using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyBlazorServerApp.Pages
{
    public class PageRazor1Model : PageModel
    {
        private IConfigurationRoot ConfigRoot;

        public string PageContent { get; private set; }

        public PageRazor1Model(IConfiguration configRoot)
        {
            ConfigRoot = (IConfigurationRoot)configRoot;
        }

        public ContentResult OnGet()
        {
            string str = "";
            foreach (var provider in ConfigRoot.Providers.ToList())
            {
                str += provider.ToString() + "\n";
            }

            return Content(str);
        }

    }
}
