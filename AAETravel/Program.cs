using AAETravel.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner
builder.Services.AddControllersWithViews();

// Serviço de Conexão
string conn = builder.Configuration.GetConnectionString("AAETravelConn");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(conn, ServerVersion.AutoDetect(conn))
);

// Serviço do Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Configuração do cookie de autenticação
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login"; // Caminho para a página de login
    options.AccessDeniedPath = "/Account/AccessDenied"; // Caminho para a página de acesso negado, se necessário
    options.LogoutPath = "/Account/Logout"; // Caminho para a página de logout, se necessário
});

var app = builder.Build();

// Configure o pipeline de solicitação HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Adicione autenticação e autorização
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();