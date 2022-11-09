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

    public HomeController(IAddition addition, ISubtraction subtraction, IMultiplication multiplication) 
    {
        _addition = addition;
        _subtraction = subtraction;
        _multiplication = multiplication;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(CalculationInputModel model)
    {
        model.Result = _addition.Add(model.FirstNumber, model.SecondNumber);
        ViewData["Result"]= model.Result;
        return View("Index");
    }
    
    [HttpPost]
    public IActionResult Subtract(CalculationInputModel model)
    {
        model.Result = _subtraction.Subtract(model.FirstNumber, model.SecondNumber);
        ViewData["Result"]= model.Result;
        return View("Index");
    }

    [HttpPost]
    public IActionResult Multiply(CalculationInputModel model)
    {
        model.Result = _multiplication.Multiply(model.FirstNumber, model.SecondNumber);
        ViewData["Result"]= model.Result;
        return View("Index");
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
