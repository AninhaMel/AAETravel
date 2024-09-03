using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using AAETravel.Models;
using AAETravel.Data;
using AAETravel.ViewModels;

namespace AAETravel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
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

        public IActionResult Local(int id, int experiencia)
        {
            var local = _context.Locais
                .AsNoTracking()
                .FirstOrDefault(l => l.Id == id);

            var experienciaModel = _context.Experiencias
                .AsNoTracking()
                .FirstOrDefault(e => e.Id == experiencia);

            var model = new LocalVM
            {
                Locais = local,
                Experiencias = experienciaModel
            };

            return View(model);
        }

        public IActionResult Criador()
        {
            CriadorVM criadores = new()
            {
                Criadores = _context.Criadores
                .AsNoTracking()
                .ToList(),
            };
            return View(criadores);
        }

        public IActionResult Favoritado()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Perfil()
        {
            // Obter o usuário atual
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                // Se o usuário não estiver autenticado, redirecione para a página de login
                return RedirectToAction("Login", "Account");
            }

            // Verifique se os dados do usuário estão presentes no banco de dados
            var usuarioData = _context.Usuarios;
                // .FirstOrDefault(u => u.Id == user.Id);

            if (usuarioData == null)
            {
                // Se os dados não estiverem presentes, redirecione para uma página de erro ou exiba uma mensagem apropriada
                return RedirectToAction("Error", "Home");
            }

            // Se os dados estiverem presentes, exiba a página de perfil
            return View(usuarioData);
        }
    }
}
