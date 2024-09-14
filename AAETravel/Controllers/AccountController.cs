using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AAETravel.ViewModels;
using AAETravel.Services;

namespace Cozastore.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUsuarioService _usuarioService;

        public AccountController(
            ILogger<AccountController> logger,
            IUsuarioService usuarioService
        )
        {
            _logger = logger;
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            var login = new LoginVM
            {
                UrlRetorno = returnUrl ?? Url.Content("~/")
            };
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                var result = await _usuarioService.LoginUsuario(login);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Usuário {login.Email} acessou o sistema!");
                    return LocalRedirect(login.UrlRetorno);
                }

                if (result.IsLockedOut)
                {
                    _logger.LogWarning($"Usuário {login.Email} está bloqueado");
                    return RedirectToAction("Lockout");
                }

                if (result.IsNotAllowed)
                {
                    ModelState.AddModelError(string.Empty, "Sua conta não está confirmada, verifique seu email!");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Usuário e/ou Senha Inválidos!");
                }
            }

            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            var userEmail = User.Identity?.Name;
            _logger.LogInformation($"Usuário {userEmail} saiu do sistema!");
            await _usuarioService.LogoffUsuario();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Registro()
        {
            var register = new RegistroVM();
            return View(register);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registro(RegistroVM register)
        {
            if (ModelState.IsValid)
            {
                var result = await _usuarioService.RegistrarUsuario(register);

                if (result != null)
                {
                    foreach (var error in result)
                    {
                        ModelState.AddModelError(string.Empty, error);
                    }
                }
                else
                {
                    register.Enviado = true;
                }
            }

            return View(register);
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmarEmail(string userId, string code)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(code))
            {
                return RedirectToAction("Index", "Home");
            }

            await _usuarioService.ConfirmarEmail(userId, code);
            return View(true);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error");
        }

        public IActionResult Lockout()
        {
            return View();
        }
    }
}
