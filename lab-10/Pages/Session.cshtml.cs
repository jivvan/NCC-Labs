using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_10.Pages;

public class SessionModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public SessionModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
