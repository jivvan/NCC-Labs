using data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using models;

namespace lab_9.Pages;

public class DeleteBookModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public Book? Book { get; set; }

    public DeleteBookModel(ApplicationDbContext db, ILogger<IndexModel> logger)
    {
        _db = db;
        _logger = logger;
    }

    public void OnGet(int id)
    {
        if (id != null)
        {
            Book = _db.Books.FirstOrDefault(b => b.Id == id);
        }
    }
    public void OnPost(int id)
    {
        _db.Books.Remove(Book);
        _db.SaveChanges();
        Response.Redirect("/Index");
    }
}
