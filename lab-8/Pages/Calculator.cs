using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using models;

namespace lab_8.Pages;

public class CalculatorModel : PageModel
{
    private readonly ILogger<CalculatorModel> _logger;

    [BindProperty]
    public Calculator Calculator { get; set; }

    public CalculatorModel(ILogger<CalculatorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public void OnPost(double number1, double number2, string operation)
    {
        Calculator = new Calculator
        {
            Number1 = number1,
            Number2 = number2,
            Operation = operation
        };
        switch (operation)
        {
            case "addition":
                Calculator.Result = number1 + number2;
                break;
            case "subtraction":
                Calculator.Result = number1 - number2;
                break;
            case "multiplication":
                Calculator.Result = number1 * number2;
                break;
            case "division":
                Calculator.Result = number1 / number2;
                break;
        }
    }
}
