using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_10.Pages;

public class CookiesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public CookiesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
