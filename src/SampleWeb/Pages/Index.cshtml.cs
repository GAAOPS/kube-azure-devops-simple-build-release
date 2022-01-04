using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using SampleWeb.Options;

namespace SampleWeb.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IOptions<ConfigOptions> config)
        {
            Configs = config.Value;
        }

        public ConfigOptions Configs { get; }

        public void OnGet()
        {
        }
    }
}