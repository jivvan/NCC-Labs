using data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using models;

namespace lab_9.Pages;

public class UpsertModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public Book? Book { get; set; }
    [FromQuery(Name = "id")]
    public int? EditId { get; set; }

    public UpsertModel(ApplicationDbContext db, ILogger<IndexModel> logger)
    {
        _db = db;
        _logger = logger;
    }

    public void OnGet()
    {
        if (EditId != null)
        {
            Book = _db.Books.FirstOrDefault(x => x.Id == EditId);
        }
        else
        {
            Book = new Book();
        }
    }
    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            foreach (var entry in ModelState)
            {
                if (entry.Value.Errors.Any())
                {
                    var fieldName = entry.Key;
                    var errorMessage = entry.Value.Errors[0];
                    Console.WriteLine(errorMessage.ErrorMessage.ToString());
                }
            }
            return;
        }
        if (Book?.Id == null)
        {
            _db.Books.Add(Book);
        }
        else
        {
            _db.Books.Update(Book);
        }
        _db.SaveChanges();
        Response.Redirect("/Index");
    }
}
