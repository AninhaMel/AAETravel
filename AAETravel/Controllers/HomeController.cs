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

    public IActionResult Pais(int id)
    {
        PaisVM pais = new()
        {
            Pais = _context.Paises
                .AsNoTracking()
                .FirstOrDefault(e => e.Id == id),
            Experiencias = _context.Experiencias
                .AsNoTracking()
                .ToList()
        };
        return View(pais);
    }

    public IActionResult Experiencia(int pais, int experiencia)
    {
        List<int> idLocal = _context.Locais
            .AsNoTracking()
            .Where(l => l.PaisId == pais)
            .Select(l => l.Id)
            .ToList();
        
        List<int> idExperienciaLocal = _context.ExperienciasLocais
            .AsNoTracking()
            .Where(el => el.ExperienciaId == experiencia && idLocal.Contains(el.LocalId))
            .Select(el => el.LocalId)
            .ToList();

        ExperienciaVM experienciaPais = new()
        {
            PaisId = pais,
            Experiencia = _context.Experiencias
                .AsNoTracking()
                .FirstOrDefault(e => e.Id == experiencia),
            Locais = _context.Locais
                .AsNoTracking()
                .Where(l => idExperienciaLocal.Contains(l.Id))
                .ToList(),          
        };

        return View(experienciaPais);


    }

    public IActionResult Local(int id)
    {
        var locais = _context.Locais
            .AsNoTracking()
            .FirstOrDefault(l => l.Id == id);

        return View(locais);
    }

    public IActionResult Criador()
    {   
        CriadorVM criadores = new(){
            Criadores = _context.Criadores
            .AsNoTracking()
            .ToList(),
        };
        return View(criadores);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
