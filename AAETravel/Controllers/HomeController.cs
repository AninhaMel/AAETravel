using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AAETravel.Models;
using Microsoft.EntityFrameworkCore;
using AAETravel.ViewModels;
using AAETravel.Data;

namespace AAETravel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Paises = _context.Paises
            .AsNoTracking()
            .ToList(),

            Agencias = _context.Agencias
            .AsNoTracking()
            .ToList(),
        };
        return View(home);
    }

    public IActionResult Experiencia()
    {
        ExperienciaVM experiencia = new(){
            Experiencias = _context.Experiencias
            .AsNoTracking()
            .ToList()
        };
        return View(experiencia);
    }

    public IActionResult Local()
    {
        LocalVM local = new(){
            Locais = _context.Locais
            .AsNoTracking()
            .ToList()
        };
        return View(local);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
