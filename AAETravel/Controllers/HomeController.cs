using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AAETravel.Models;
using Microsoft.EntityFrameworkCore;
using AAETravel.ViewModels;

namespace AAETravel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
           Paises = DbSet<Pais>.Paises.ToList(),
            Agencias = DbSet<Agencia>.Agencias.ToList()
        };
        return View(home);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
