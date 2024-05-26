using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AAETravel.Models;

namespace AAETravel.Controllers;

public class ExperienciaController : Controller
{
    private readonly ILogger<ExperienciaController> _logger;

    public ExperienciaController(ILogger<ExperienciaController> logger)
    {
        _logger = logger;
    }

    public IActionResult Experiencia()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
