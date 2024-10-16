using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using AAETravel.Models;
using AAETravel.Data;
using AAETravel.ViewModels;
using System.Security.Claims;

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
                Paises = _context.Paises.AsNoTracking().ToList(),
                Agencias = _context.Agencias.AsNoTracking().ToList(),
            };
            return View(home);
        }

        public IActionResult Pais(int id)
        {
            PaisVM pais = new()
            {
                Pais = _context.Paises.AsNoTracking().FirstOrDefault(e => e.Id == id),
                Experiencias = _context.Experiencias.AsNoTracking().ToList()
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
                Experiencia = _context.Experiencias.AsNoTracking().FirstOrDefault(e => e.Id == experiencia),
                Locais = _context.Locais.AsNoTracking().Where(l => idExperienciaLocal.Contains(l.Id)).ToList(),
            };

            return View(experienciaPais);
        }

        public IActionResult Local(int id, int experiencia)
        {
            var local = _context.Locais.AsNoTracking().FirstOrDefault(l => l.Id == id);
            var experienciaModel = _context.Experiencias.AsNoTracking().FirstOrDefault(e => e.Id == experiencia);

            var model = new LocalVM
            {
                ExperienciaId = experienciaModel.Id,
                PaisId = local.PaisId,
                Locais = local,
                Experiencias = experienciaModel
            };

            var userId = _userManager.GetUserId(User);
            if (userId != null)
            {
                model.Favoritado = _context.Listas.Any(f => f.UsuarioId == userId && f.LocalId == local.Id);
            }
            return View(model);
        }

        public IActionResult Criador()
        {
            CriadorVM criadores = new()
            {
                Criadores = _context.Criadores.AsNoTracking().ToList(),
            };
            return View(criadores);
        }

        [Authorize]
        public async Task<IActionResult> Favoritado()
        {
            var usuarioId = _userManager.GetUserId(User);  // Obtém o ID do usuário logado
            var listas = await _context.Listas
                .Where(f => f.UsuarioId == usuarioId)  // Filtro pelo ID do usuário
                .Include(f => f.Local)  // Inclui as informações do local favoritado
                .ToListAsync() ?? new List<Lista>();  // Garante que uma lista vazia seja passada se não houver favoritos

            return View(listas);  // Passa a lista para a view
        }

        public IActionResult Perfil()
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuario = _context.Usuarios.Find(usuarioId);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        public IActionResult EditarPerfil()
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuario = _context.Usuarios.Find(usuarioId);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Favoritar(int localId, int experienciaId)
        {
            var userId = _userManager.GetUserId(User);
            var favoritoExistente = _context.Listas.FirstOrDefault(f => f.UsuarioId == userId && f.LocalId == localId);

            if (favoritoExistente == null)
            {
                var favorito = new Lista
                {
                    UsuarioId = userId,
                    LocalId = localId,
                    DataCadastro = DateTime.Now
                };
                _context.Listas.Add(favorito);
                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Listas.Remove(favoritoExistente);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Local", new { id = localId, experiencia = experienciaId });
        }

    }
}
