using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Web.Models;
using Calculations;

namespace SimpleCalculator.Web.Controllers;

public class HomeController : Controller
{
    private readonly IAddition _addition;
    private readonly ISubtraction _subtraction;
    private readonly IMultiplication _multiplication;
    private readonly IDivision _division;

    public HomeController(IAddition addition, ISubtraction subtraction, IMultiplication multiplication, IDivision division)
    {
        _addition = addition;
        _subtraction = subtraction;
        _multiplication = multiplication;
        _division = division;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(CalculationInputModel model)
    {
        model.Result = _addition.Add(model.FirstNumber, model.SecondNumber);
        return View("Index", model);
    }

    [HttpPost]
    public IActionResult Subtract(CalculationInputModel model)
    {
        model.Result = _subtraction.Subtract(model.FirstNumber, model.SecondNumber);
        return View("Index", model);
    } 

    [HttpPost]
    public IActionResult Multiply(CalculationInputModel model)
    {
        model.Result = _multiplication.Multiply(model.FirstNumber, model.SecondNumber);
        return View("Index", model);
    }

    [HttpPost]
    public IActionResult Divide(CalculationInputModel model)
    {
        if (model.SecondNumber == 0)
        {
            ModelState.AddModelError("SecondNumber", "Unable to divide by zero.");
        }
        else
        {
            model.Result = _division.Divide(model.FirstNumber, model.SecondNumber);
        }
        return View("Index", model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
