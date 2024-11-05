using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AAETravel.Models;
using AAETravel.Data;
using AAETravel.ViewModels;
using System.Security.Claims;
using AAETravel.Services;

namespace AAETravel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly IUsuarioService _usuarioService;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, IUsuarioService usuarioService)
        {
            _logger = logger;
            _context = context;
            _usuarioService = usuarioService;
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

        public async Task<IActionResult> Local(int id, int experiencia)
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

            var user = await _usuarioService.GetUsuarioLogado();
            if (user != null)
            {
                model.Favoritado = _context.Listas.Any(f => f.UsuarioId == user.UsuarioId && f.LocalId == local.Id);
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

            var user = await _usuarioService.GetUsuarioLogado();
            var listas = await _context.Listas
                .Where(f => f.UsuarioId == user.UsuarioId)
                .Include(f => f.Local)
                .ThenInclude(l => l.ExperienciasLocais)
                .ThenInclude(el => el.Experiencia)
                .ToListAsync();

            var listaVM = new List<ListaVM>();
            foreach (var item in listas)
            {
                ListaVM lista = new()
                {
                    Local = item.Local,
                    Experiencia = item.Local.ExperienciasLocais[0].Experiencia,
                };
                listaVM.Add(lista);
            }
            return View(listaVM);
        }

        public IActionResult Perfil()
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuario = _context.Usuarios.Find(usuarioId);
            if (usuario == null)
                return RedirectToAction("Login", "Account");

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
                return RedirectToAction("Login", "Account");

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Favoritar(int localId, int experienciaId)
        {
            var user = await _usuarioService.GetUsuarioLogado();
            if (user == null)
                return RedirectToAction("Login", "Account");
            var favoritoExistente = _context.Listas.FirstOrDefault(f => f.UsuarioId == user.UsuarioId && f.LocalId == localId);

            if (favoritoExistente == null)
            {
                var favorito = new Lista
                {
                    UsuarioId = user.UsuarioId,
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

        [HttpPost]
        public async Task<IActionResult> EditarPerfil(Usuario usuario, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var usuarioExistente = await _context.Usuarios.FindAsync(usuarioId);
                if (usuarioExistente == null)
                return RedirectToAction("Login", "Account");

                if (usuarioExistente != null)
                {
                    usuarioExistente.Nome = usuario.Nome;
                    usuarioExistente.Telefone = usuario.Telefone;
                    usuarioExistente.Descricao = usuario.Descricao;
                    usuarioExistente.Cidade = usuario.Cidade;

                    if (foto != null && foto.Length > 0)
                    {
                        var caminhoDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "perfis");

                        if (!Directory.Exists(caminhoDiretorio))
                        {
                            Directory.CreateDirectory(caminhoDiretorio);
                        }

                        var filePath = Path.Combine(caminhoDiretorio, foto.FileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await foto.CopyToAsync(stream);
                        }

                        usuarioExistente.Foto = $"/img/perfis/{foto.FileName}";
                    }

                    await _context.SaveChangesAsync();
                    return RedirectToAction("Perfil");
                }
            }

            return View(usuario);
        }

    }
}
