using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_10.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost(string firstName, string lastName, string email, string storage)
    {
        if (storage == "session")
        {
            HttpContext.Session.SetString("FirstName", firstName);
            HttpContext.Session.SetString("LastName", lastName);
            HttpContext.Session.SetString("Email", email);
            Response.Redirect("/Session");
        }
        else
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),
            };
            Response.Cookies.Append("FirstName", firstName);
            Response.Cookies.Append("LastName", lastName);
            Response.Cookies.Append("email", email);
            Response.Redirect("/Cookies");
        }
    }
}
