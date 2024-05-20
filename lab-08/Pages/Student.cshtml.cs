using data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using models;

namespace lab_8.Pages;

public class StudentModel : PageModel
{
    public StudentRepository _repository;
    public List<Student> Students { get; set; }

    [BindProperty]
    public Student Student { get; set; }

    public StudentModel(StudentRepository repository)
    {
        _repository = repository;
    }

    public void OnGet()
    {
        Student = new Student();
        Students = _repository.GetStudents();
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            _repository.AddStudent(Student);
            Response.Redirect("/Student");
            Students = _repository.GetStudents();
            Student = new Student();
            return Page();
        }
        return Page();
    }
}

