using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AAETravel.Migrations
{
    /// <inheritdoc />
    public partial class criarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Agencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Link = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencia", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Criador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sobre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criador", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fundo = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Onda = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Musica = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Icon = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Localizacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorarioFuncionamento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<double>(type: "double", nullable: false),
                    Longitude = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Local_Pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExperienciasLocais",
                columns: table => new
                {
                    LocalId = table.Column<int>(type: "int", nullable: false),
                    ExperienciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciasLocais", x => new { x.ExperienciaId, x.LocalId });
                    table.ForeignKey(
                        name: "FK_ExperienciasLocais_Experiencia_ExperienciaId",
                        column: x => x.ExperienciaId,
                        principalTable: "Experiencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienciasLocais_Local_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Local",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lista_Local_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Local",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lista_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "Id", "Cor", "Descricao", "Foto", "Link", "Nome" },
                values: new object[,]
                {
                    { 1, "#4C8CB7", "nao sei", "/img/experiencias/agencias/Booking.png", "https://www.booking.com/?aid=348858&label=gx-br-booking-booking-sd-nhvs", "Booking.com" },
                    { 2, "#E4C34E", "nao sei", "/img/experiencias/agencias/Expedia.png", "https://www.expedia.com.br/?locale=pt_BR&siteid=69&semcid=BR.B.BING.BT-c-PT.GT&semdtl=a1686369326.b11322714033213817.g1kwd-82670466053188.e1c.m1ab46ac5af65f1b662a4dca08af7b5eb5.r184009ff3402fd6a93a30e8f5d7b5a1cca5430f54f9df56f741e2a4a84089cfd9.c1Cm6dAowtvW27WbJtvR_5Vw.j1147720.k1.d182669875489872.h1e.i1.l1.n1.o1.p1.q1.s1.t1.x1.f1.u1.v1.w1&msclkid=ab46ac5af65f1b662a4dca08af7b5eb5", "Expedia" },
                    { 3, "#8FB6C8", "nao sei", "/img/experiencias/agencias/STA Travel.png", "https://us.jetcost.com/en?&msclkid=e1b5099fa5b612965fdb6fcdfc044c18&utm_source=bing&utm_medium=cpc&utm_campaign=US-EN_B1_F_S_JC_Comp_Global-EXT_mixed&utm_term=sta%20travel%20com&utm_content=Sta%20Travel&gclid=e1b5099fa5b612965fdb6fcdfc044c18&gclsrc=3p.ds", "STA Travel" },
                    { 4, "#00BF63", "nao sei", "/img/experiencias/agencias/TripAdvisor.png", "https://www.tripadvisor.com.br/", "TripAdvisor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dad88c0-d861-4b60-8df7-71eb657bbf8e", null, "Visitante", "VISITANTE" },
                    { "76339ba3-fae1-46bd-9b64-49534182a689", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5a77beee-9a2a-4ac6-b8fb-390c209a2152", 0, "7bdaae47-da76-413f-b266-1804020737de", "any.lima@gmail.com", true, true, null, "ANY.LIMA@GMAIL.COM", "ANY", "AQAAAAIAAYagAAAAEP0J8UklYpM2Mlm0YrPkagAcMK7EZfi5VQlA0rlJ9pqjKm3vvNNNqG+FwEnWv01o7A==", null, false, "5ae7038f-9cfd-4cfb-8df4-10209aae82f1", false, "any" },
                    { "80f41a70-951e-4356-9ec2-8dddc2fc598a", 0, "c3d2cedc-8c4a-426f-8a0b-8eb7fe050753", "joaosouza@gmail.com", true, true, null, "JOAOSOUZA@GMAIL.COM", "JOAO", "AQAAAAIAAYagAAAAEHTdTYCF0x/3KA/W8j502bU47fdWy/myt0fgg0wKMTF+0JKpJ1KJr2M4fnSQxE7vmg==", null, false, "fdf94c1e-b272-431c-b4aa-06bc919bfb96", false, "joao" },
                    { "b6ca8249-53d1-4907-b6e8-dabf2673df15", 0, "71b5b903-9877-43d7-95a5-9db2410ee73c", "eduardo.dametto@gmail.com", true, true, null, "EDUARDO.DAMETTO@GMAIL.COM", "DAMETTO", "AQAAAAIAAYagAAAAEGmFnmz721y+YCN1oUxy89XoNazXSWucasGMT995UqjJW9MJzPY2mC01kZG/yA8kbg==", null, false, "d3e4fd6e-2f60-4c36-a88f-0785f4633abb", false, "dametto" },
                    { "d99ee5a6-68bc-463d-8e38-c5e471ab55fb", 0, "88074177-a5d5-4645-9fbd-88deefdd2ae8", "ana.silva@aaetravel.com", true, true, null, "ANA.SILVA@AAETRAVEL.COM", "ANA", "AQAAAAIAAYagAAAAENA3+TLoMNMT32RUpFlW95sda9j+PSPeRT5V0k9M46mJoh2hFqRDqfyXPDYVljZJNQ==", null, false, "9a16a0ec-5bc8-4aa0-8e4f-81854d890843", false, "ana" },
                    { "de36459b-fa4d-4eda-bdc3-12b9eb14c516", 0, "48870601-ae41-4e5f-bb15-16df70e21872", "eduardo.oliveira@aaetravel.com", true, true, null, "EDUARDO.OLIVEIRA@AAETRAVEL.COM", "EDUARDO", "AQAAAAIAAYagAAAAEMGqfwRRcPMYt0thyuMRmuwc91E117enoZzZ1JVppEeTNiDMx/52mWuvJ0pw8U+HbQ==", null, false, "7462ec0e-872b-482a-94a5-313e675b4678", false, "Eduardo" }
                });

            migrationBuilder.InsertData(
                table: "Criador",
                columns: new[] { "Id", "Foto", "Nome", "Sobre" },
                values: new object[,]
                {
                    { 1, "/img/Criador/Nunes.png", "Eduardo Nunes", "Programador full stack com ênfase em front-end e criação de layouts" },
                    { 2, "/img/Criador/Ana.jpg", "Ana Clara Mello", "Programadora e Dsigner com ênfase em Protótipo" },
                    { 3, "/img/Criador/Any.png", "Any Gabrieli", "Desenvolvedora e Escritora com ênfase em Documentação" },
                    { 4, "/img/Criador/dametto.png", "Eduardo Dametto", "Desenvolvedor e Disgner com ênfase em criação de protótipo e Figma" }
                });

            migrationBuilder.InsertData(
                table: "Experiencia",
                columns: new[] { "Id", "Cor", "Foto", "Fundo", "Musica", "Nome", "Onda" },
                values: new object[,]
                {
                    { 1, "#0E6500", "/img/experiencias/natureza.png", "/img/experiencias/natureza.png", "/Music/Natureza.mp3", "Natureza", "/img/outros/paralax/preto-verde.png" },
                    { 2, "#E5B712", "/img/experiencias/restaurante.png", "/img/experiencias/restaurante.png", "/Music/Restaurante.mp3", "Restaurantes", "/img/outros/paralax/preto-amarelo.png" },
                    { 3, "#A12BA4", "/img/experiencias/vida-noturna.png", "/img/experiencias/vida-noturna.png", "/Music/Vida-Noturna.mp3", "Vida Noturna", "/img/outros/paralax/preto-roxo.png" },
                    { 4, "#8A6C47", "/img/experiencias/espiritualidade.png", "/img/experiencias/espiritualidade.png", "/Music/Espiritualidade.mp3", "Espiritualidade", "/img/outros/paralax/preto-marrom.png" },
                    { 5, "#4B778A", "/img/experiencias/compras.png", "/img/experiencias/compras.png", "/Music/Compras.mp3", "Compras", "/img/outros/paralax/preto-azul.png" },
                    { 6, "#be2414", "/img/experiencias/cultura.png", "/img/experiencias/cultura.png", "/Music/Cultura.mp3", "Cultura", "/img/outros/paralax/preto-beje.png" }
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "Cor", "Descricao", "Foto", "Icon", "Nome" },
                values: new object[,]
                {
                    { 1, "#009C3B", "O Brasil é um país vasto e diverso, famoso por suas paisagens deslumbrantes e rica cultura. O Rio de Janeiro, com o Cristo Redentor e suas praias icônicas, e São Paulo, um centro financeiro vibrante, são apenas algumas das atrações. No nordeste, cidades como Salvador e Recife encantam com suas praias tropicais e rica história. Além de sua beleza natural, o Brasil possui uma diversidade religiosa significativa, com igrejas como a Basílica de Nossa Senhora Aparecida e a Catedral da Sé, que atraem milhões de visitantes. A Igreja Universal do Reino de Deus, uma das maiores denominações evangélicas do país, exemplifica a forte presença do cristianismo na cultura brasileira. Conhecido também por seu animado carnaval, música contagiante e culinária variada, o Brasil é um destino acolhedor, perfeito para quem busca aventura e uma rica experiência cultural.", "/img/pais/Brasil.png", "/img/pais/icons/Brasil.png", "Brasil" },
                    { 2, "#0033A0", "Os Estados Unidos oferecem uma vasta diversidade de destinos para todos os tipos de viajantes. De vibrantes metrópoles como Nova York e Los Angeles, repletas de cultura, entretenimento e gastronomia, a maravilhas naturais como o Grand Canyon e os parques nacionais de Yellowstone e Yosemite, o país proporciona experiências únicas e inesquecíveis. Além disso, cidades históricas como Washington, D.C., e Boston trazem uma rica herança cultural e momentos marcantes da história americana. Seja qual for o seu estilo de viagem, os EUA têm algo especial a oferecer.", "/img/pais/EUA.png", "/img/pais/icons/EUA.png", "EUA" },
                    { 3, "#0055A4", "A França é um país encantador que combina história, cultura e beleza natural. Paris, a Cidade Luz, é famosa por seus monumentos icônicos, como a Torre Eiffel e o Museu do Louvre, além de suas charmosas ruas e cafés. No interior, vilarejos pitorescos como Provence e Alsácia revelam o charme do campo francês, enquanto o Vale do Loire é conhecido por seus castelos deslumbrantes. A Riviera Francesa oferece praias deslumbrantes e glamour, enquanto a região da Normandia traz paisagens costeiras e importantes memórias históricas. A França é um destino que mistura sofisticação e simplicidade, perfeito para todos os gostos.", "/img/pais/França.png", "/img/pais/icons/Franca.png", "França" },
                    { 4, "#CF142B", "A Inglaterra é um país repleto de história e tradições, com uma mistura encantadora de antigas paisagens rurais e cidades modernas. Londres, a capital, é um centro global de cultura, oferecendo atrações icônicas como o Big Ben, o Palácio de Buckingham e o Museu Britânico. Fora da capital, o interior inglês revela vilas encantadoras, como Cotswolds, e cidades históricas como Bath e Oxford. O litoral do país, com seus penhascos impressionantes e praias tranquilas, também oferece beleza natural. A Inglaterra é um destino onde a história se encontra com a modernidade, ideal para quem busca diversidade cultural e paisagens deslumbrantes.", "/img/pais/Inglaterra.png", "/img/pais/icons/Inglaterra.png", "Inglaterra" },
                    { 5, "#008C8C", "A Itália é um país vibrante e apaixonante, conhecido por sua rica história, arte incomparável e culinária renomada. Roma, a capital, encanta com monumentos antigos, como o Coliseu e o Vaticano. Veneza, com seus canais românticos, é única no mundo, assim como Florença, berço do Renascimento, que abriga tesouros artísticos como a famosa escultura de Davi, de Michelangelo. O sul do país oferece paisagens deslumbrantes na Costa Amalfitana e na Sicília, enquanto a região da Toscana é conhecida por suas colinas ondulantes, vinhedos e cidades medievais. Viajar pela Itália é uma imersão na beleza, na cultura e no estilo de vida (dolce vita)", "/img/pais/Italia.png", "/img/pais/icons/Italia.png", "Itália" },
                    { 6, "#006600", "Portugal é um país encantador, conhecido por suas cidades históricas, litoral deslumbrante e cultura vibrante. Lisboa, a capital, é uma mistura de tradição e modernidade, com suas ruas de paralelepípedos, miradouros e o famoso bairro de Belém. Porto, no norte, encanta com suas ruelas pitorescas e o famoso vinho do Porto. As regiões do Algarve e da Madeira oferecem praias paradisíacas e paisagens naturais impressionantes. Além disso, Portugal tem uma rica herança cultural, com influências mouriscas, romanas e medievais, que se refletem em sua arquitetura, gastronomia e festividades. É um destino acolhedor, ideal para quem busca beleza, história e tranquilidade.", "/img/pais/Portugal.png", "/img/pais/icons/Portugal.png", "Portugal" },
                    { 7, "#74ACDF", "A Argentina é um país vibrante e diversificado, conhecido por sua rica cultura, paisagens deslumbrantes e história fascinante. De Buenos Aires, a capital cosmopolita com suas famosas avenidas e vida noturna animada, até a Patagônia, com suas montanhas majestosas e glaciares impressionantes, há muito a ser explorado. Mendoza encanta com suas vinícolas e paisagens andinas, enquanto as Cataratas do Iguaçu, na fronteira com o Brasil, são um espetáculo natural de tirar o fôlego. Cada região da Argentina oferece experiências únicas para todos os tipos de viajantes.", "/img/pais/Argentina.png", "/img/pais/icons/Argentina.png", "Argentina" },
                    { 8, "#00008B", "A Austrália é um país fascinante, famoso por suas paisagens únicas, cidades modernas e rica biodiversidade. Sydney, com sua icônica Opera House e a Harbour Bridge, combina uma vida urbana vibrante com belas praias, como Bondi Beach. Melbourne é o centro cultural do país, conhecida por sua arte, gastronomia e eventos esportivos. O interior australiano, o vasto Outback, oferece cenários selvagens e impressionantes, como o Uluru, um dos símbolos mais reverenciados da cultura aborígene. A Grande Barreira de Corais, no nordeste, é um paraíso para mergulhadores e amantes da natureza. A Austrália também é lar de uma vida selvagem única, com cangurus, coalas e uma impressionante diversidade de ecossistemas. É um destino perfeito para quem procura aventura, natureza e cultura em um ambiente acolhedor.", "/img/pais/Australia.png", "/img/pais/icons/Australia.png", "Austrália" },
                    { 9, "#FFFFFF", "A Coreia do Sul é um país vibrante, conhecido por sua combinação harmoniosa de tradição milenar e inovação moderna. Seul, a capital, é uma metrópole dinâmica, onde arranha-céus futuristas convivem com palácios históricos como o Gyeongbokgung. A cidade de Busan, com suas praias e mercados de frutos do mar, oferece uma experiência costeira encantadora. A paisagem montanhosa da Coreia do Sul é perfeita para caminhadas, com parques nacionais como o Seoraksan oferecendo vistas impressionantes. A rica herança cultural coreana se reflete em suas cerimônias, templos budistas e na popularidade mundial da K-pop e do K-drama. A gastronomia sul-coreana, com pratos icônicos como o kimchi e o bulgogi, também é parte fundamental de sua cultura. É um destino ideal para quem busca uma mistura de tradição, modernidade e paisagens deslumbrantes.", "/img/pais/Coreia-Sul.png", "/img/pais/icons/Coreia-Sul.png", "Coreia do Sul" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1dad88c0-d861-4b60-8df7-71eb657bbf8e", "5a77beee-9a2a-4ac6-b8fb-390c209a2152" },
                    { "76339ba3-fae1-46bd-9b64-49534182a689", "5a77beee-9a2a-4ac6-b8fb-390c209a2152" },
                    { "1dad88c0-d861-4b60-8df7-71eb657bbf8e", "80f41a70-951e-4356-9ec2-8dddc2fc598a" },
                    { "1dad88c0-d861-4b60-8df7-71eb657bbf8e", "b6ca8249-53d1-4907-b6e8-dabf2673df15" },
                    { "76339ba3-fae1-46bd-9b64-49534182a689", "b6ca8249-53d1-4907-b6e8-dabf2673df15" },
                    { "1dad88c0-d861-4b60-8df7-71eb657bbf8e", "d99ee5a6-68bc-463d-8e38-c5e471ab55fb" },
                    { "76339ba3-fae1-46bd-9b64-49534182a689", "d99ee5a6-68bc-463d-8e38-c5e471ab55fb" },
                    { "1dad88c0-d861-4b60-8df7-71eb657bbf8e", "de36459b-fa4d-4eda-bdc3-12b9eb14c516" },
                    { "76339ba3-fae1-46bd-9b64-49534182a689", "de36459b-fa4d-4eda-bdc3-12b9eb14c516" }
                });

            migrationBuilder.InsertData(
                table: "Local",
                columns: new[] { "Id", "Descricao", "Foto", "HorarioFuncionamento", "Latitude", "Localizacao", "Longitude", "Nome", "PaisId", "Telefone" },
                values: new object[,]
                {
                    { 1, "O Parque Nacional Los Glaciares localiza-se na região da Patagônia Argentina no sudoeste da Província de Santa Cruz, Argentina, sendo o segundo maior do país. O parque foi instituído pelo governo em 1937, e batizado Los Glaciares pois a área do parque nacional abriga inúmeros glaciares. ", "/imgpaises/imgArgentina/Natureza/Parque Nacional Los Glaciales (Provícia de Santa Cruz).png", "Abre no verão de 1º de setembro a 30 de abril das 8h às 18h e no Inverno de 1 de maio a 31 de agosto das 9h às 16h.", -50.330528176230857, "Parque Nacional da Província de Santa Cruz.", -73.234180113496933, "Parque Nacional Los Glaciales (Provícia de Santa Cruz)", 7, "542902491005" },
                    { 2, "O parque é o mais antigo dos parques nacionais argentinos. Foi criado em 1934, sobre a base da doação de três léguas quadradas (225.000 ha) feita por Francisco Pascasio Moreno em 1903 para sua criação.", "/imgpaises/imgArgentina/Natureza/Parque-Nacional-nahuel-huapi.png", "Semana inteira/ 09:00 até 19:00", -40.938009000000001, "Lago Nahuel Huapi- região da Patagônia.", -71.613045999999997, "Parque Nacional Nauhel Huapi (Patagônia)", 7, "+54 11 5091-7200" },
                    { 3, "O que mais chama a atenção dentro do parque é a topografia montanhosa, além da enorme quantidade de áreas verdes, dos lagos, dos bosques e da paisagem natural como um todo. Ainda que o parque esteja em território argentino, parte dele está em território chileno, então algumas montanhas que se vê dentro do parque pertencem ao Chile. O lugar também é famoso por ser o final da Ruta N3, que faz parte do sistema de rodovias panamericanas.", "/imgpaises/imgArgentina/Natureza/Parque Nacional Tierra del Fuego (Ushuaia).png", "Semana inteira/ 08:00 até 20:00", -54.834752257513969, "RN3 kilometro 3067, V9410 Ushuaia, Tierra del Fuego.", -68.446483844495091, "Parque Nacional Tierra del Fuego (Ushuaia)", 7, "+54 2901 57-7931" },
                    { 4, "Na entrada do Jardim Zoológico é possível comprar comida para os animal. Assim, quando você entrar, poderá alimentar diversas espécies e observar inúmeros bichos que não vemos no dia a dia.", "/imgpaises/imgArgentina/Natureza/Jardim Zoológico de Buenos Aires (Buenos Aires).png", "Abre de Terça a Domingo das 11:00 até as 18:00 ", -34.559304312884272, "Av. Sarmiento 2601, C1045 Buenos Aires.", -59.018726315996368, "Jardim Zoológico de Buenos Aires (Buenos Aires)", 7, "+54 11 5091-7200" },
                    { 5, "Não é um zoológico e nem é um jardim botânico, também não é uma fazenda e tampouco um museu de história natural. O Temaikén, distante cerca de 40 minutos de Buenos Aires, é uma mistura de tudo isso e um pouco mais. Um bioparque para viver a natureza de distintas maneiras e, sobretudo, com muita diversão, especialmente para a criançada.", "/imgpaises/imgArgentina/Natureza/Bioparque Temaikén (Buenos Aires).png", "Abre a semana inteira das 10:00 as 19:00", -34.340246952986398, "RP25, B1625 Belén de Escobar, Provincia de Buenos Aires.", -58.808698621294234, "Bioparque Temaikén (Buenos Aires)", 7, "+54 348 443-6980" },
                    { 6, "O Parque Nacional Iguazú é uma área protegida, criada na Argentina no ano 1934 com o objetivo de conservar as Cataratas do Iguaçu e a biodiversidade que as rodeia. Localizado no norte da província de Misiones, o parque conta com uma superfície aproximada de 67.000 hectares e a sua entrada está a 7 km de Puerto Iguazú.", "/imgpaises/imgArgentina/Natureza/Parque Nacional Iguazú (Missiones- Puerto Iguazú).png", "Todos os dias das 08:00 as 18:00", -25.660018284382353, "Rota 101 Km 142, N3370 Puerto Iguazú, Misiones.", -54.444980587863554, "Parque Nacional Iguazú (Missiones- Puerto Iguazú)", 7, "+54 9 3757 67-4714" },
                    { 7, "Há mais de 40 anos, San Telmo, bairro localizado ao sul de Buenos Aires, recebe pessoas da Argentina e do mundo inteiro que visitam o bairro aos domingos para conhecer a famosa Feira de San Telmo. Além dos diversos produtos de antiguidade, a feira também vende artesanato local, produtos com temas da cidade, livros, discos, camisetas, óculos, chapéus, cartões, fotografias, CDs, pôsteres, roupas, calçados e muito mais!", "/imgpaises/imgArgentina/Compras/Feira de San Telmo (Buenos Aires).png", "Domingo das 10:00 até as 17:00", -34.620275228319329, "Rua Defensa, San Telmo, Buenos Aires.", -58.371204919145264, "Feira de San Telmo (Buenos Aires)", 7, "+54 9 3757 67-4714" },
                    { 8, "Aos falar de compras em Buenos Aires um dos primeiros lugares que surgem na mente são as Galerias Pacífico. O edifício do centro comercial é do fim do século XIX e sua cúpula central foi pintada em 1946. O shopping é tão bonito e bem decorado que recomendamos a visita não apenas a quem deseja fazer compras como a quem procura apenas um lugar para bater perna e quer ver coisas bonitas. O charme da arquitetura das Galerias é ímpar, cheio de murais, colunas e um teto lindíssimo. A arquitetura do shopping é tão imponente que o edifício é considerado monumento histórico nacional.", "/imgpaises/imgArgentina/Compras/Galerias Pacífico (Buenos Aires).png", "Abre todos os dias das 10:00 até as 21:00", -34.599132908132724, "Av. Córdoba 550, C1054 Buenos Aires.", -58.374832153552276, "Galerias Pacífico (Buenos Aires)", 7, "+54 11 5555-5110" },
                    { 9, "Instalado nos antigos edifícios existentes na Propriedade Ferroviária localizada no bairro de Palermo, entre as avenidas Juan B. Justo e Santa Fé, e as ruas Godoy Cruz e Paraguai.As lojas desenvolvem-se para o interior dos espaços cobertos existentes e as áreas comuns são quase inteiramente exteriores. O setor construído é caracterizado pela presença das estruturas de tijolo do viaduto ferroviário que definem o interior urbano e as fachadas exteriores.", "/imgpaises/imgArgentina/Compras/Distrito Arcos Buenos aires.png", "Abre todos os dias das 10:00 até as 22:00", -34.580411966128082, "Paraguay 4979, C1425BTC C1425BTA, Buenos Aires.", -58.427866749837804, "Distritos Arcos (Buenos Aires)", 7, "+54 800-222-2299" },
                    { 10, "Palácios requintados e prédios residenciais luxuosos se combinam a galerias de arte e butiques exclusivas para fazer de Retiro o lugar perfeito para aqueles que gostam de sofisticação. No entanto, o tráfego contínuo de pedestres nos terminais de trens e de ônibus de Retiro, além dos vários caminhões que chegam e saem do porto, mostram que esse bairro nunca descansa. Em um minuto, você está andando por uma estrada repleta de mansões e vitrines de lojas luxuosas. No minuto seguinte, você se vê rodeado por uma multidão apressada para pegar o trem ou ônibus. É a combinação da constante movimentação de pessoas e o ambiente luxuoso e tranquilo que define Retiro e também Buenos Aires, uma cidade cheia de contrastes.", "/imgpaises/imgArgentina/Compras/Patio Bullrich (Marselha).png", "Abre todos os dias das 10:00 até as 22:00", -32.955524323926134, "Avenida Del Libertador 750.", -68.85890340338014, "Patio Bullrich (Marselha)", 7, "+54 800-222-2299" },
                    { 11, "A 15km do centro de Mendoza você encontrará uma boa maneira de resolver suas compras em um só lugar. No Palmares Open Mall é possível encontrar de vestuário a artigos de artesanato, passando pelos vinhos, claro! Se você não resiste a uma voltinha em um grande centro comercial, essa pode ser uma boa pedida. O shopping é bem ao estilo brasileiro: são 120 lojas que vão de grandes marcas a pequenas boutiques. Prático para uma volta e uma refeição rápida. Destaque para o restaurante Don Mario, que serve uma das mais famosas parrilladas da cidade.", "/imgpaises/imgArgentina/Compras/Palmares Open Mall (Godoy Cruz).png", "Abre todos os dias das 10:00 até as 21:00", -34.588693988159875, "RP82 2650, M5501 Godoy Cruz, Mendoza.", -58.384044676325388, "Palmares Open Mall (Godoy Cruz)", 7, "+54 261 348-1200" },
                    { 12, "Patio Olmos é uma galeria comercial de grande importância arquitetônica em Córdoba, Argentina, e a mais importante da cidade.", "/imgpaises/imgArgentina/Compras/Patio Olmos (Córdoba).png", "Abre todos os dias das 10:00 até as 22:00 ", -31.419589681155919, "Av. Vélez Sarsfield 361.", -64.188240681400345, "Patio olmos (córdoba)", 7, "+54 351 570-4199" },
                    { 13, "Mais conhecido como o maior bairro de Buenos Aires, Palermo é dividido em partes diferentes, cada uma com uma identidade exclusiva. Palermo Chico é a área mais sofisticada. Caracterizada pelas magníficas mansões, avenidas majestosas, prédios residenciais e por abrigar o Museu de Arte Latino-Americana de Buenos Aires (MALBA), essa região é um dos lugares favoritos dos moradores. O maior parque da cidade, Bosques de Palermo, é o ponto de interesse mais famoso de Palermo. Ele também é um destino popular entre aqueles que querem fazer caminhadas, piqueniques, andar de patins e de bicicleta. Em Palermo Soho, o cenário se torna muito mais moderno. Nos finais de semana, compradores lotam essa área que é famosa pelos cafés descolados e lojas de design exclusivo. Já Palermo Hollywood, conhecida por contar com um grande número de restaurantes, bares e boates, é o lugar preferido dos viajantes que querem se divertir à noite e comemorar ocasiões especiais.", "/imgpaises/imgArgentina/VidaNoturna/Niceto Club (Buenos Aires).png", "Abre todos os dias 24 horas por dia", -34.587035068869078, "Calle Cnel Niceto Vega 5510.", -58.438866074468983, "Niceto Club (Buenos Aires)", 7, "+54 351 570-4199" },
                    { 14, "Considerada uma das melhores casas de tango de Buenos Aires, o Señor Tango oferece um espetáculo inesquecível e muito emocionante. O show é envolvente do início ao fim, apresentando belas coreografias – algumas com certo toque acrobático – que encantam a todo o tipo de público. A apresentação ainda conta com a participação de ótimos cantores e músicos que, em alguns momentos do espetáculo, interagem com a plateia.", "/imgpaises/imgArgentina/VidaNoturna/Senor Tango (Buenos Aires).png", "Abre todos os dias das 20:00 até as 00:00", -34.569266985549362, "Vieytes 1655, C1276 Cdad.", -58.420529532143043, "Senor Tango (Buenos Aires)", 7, "+54 11 4303-0231" },
                    { 15, "No Ice Bar Puerto Iguazú tudo é feito de gelo: as paredes, os móveis, a decoração e, inclusive, os copos. E, para manter tudo congelado, a temperatura do bar é de -10ºC. Uma grande diferença para o clima da cidade, que pode passar dos 30° no verão.", "/imgpaises/imgArgentina/VidaNoturna/Icebar Iguazu (Puerto Iguazú).png", "Abre todos os dias das 14:00 até a 00:00", -34.652514887426548, "Ruta Nacional 12 KM 5", -58.375939274465793, "Icebar Iguazu (Puerto Iguazú)", 7, "+54 11 4778-1500 " },
                    { 16, "Mais conhecido como o maior bairro de Buenos Aires, Palermo é dividido em partes diferentes, cada uma com uma identidade exclusiva. Palermo Chico é a área mais sofisticada. Caracterizada pelas magníficas mansões, avenidas majestosas, prédios residenciais e por abrigar o Museu de Arte Latino-Americana de Buenos Aires (MALBA), essa região é um dos lugares favoritos dos moradores. O maior parque da cidade, Bosques de Palermo, é o ponto de interesse mais famoso de Palermo. Ele também é um destino popular entre aqueles que querem fazer caminhadas, piqueniques, andar de patins e de bicicleta. Em Palermo Soho, o cenário se torna muito mais moderno", "/imgpaises/imgArgentina/VidaNoturna/Crobar (Buenos Aires).png", "Abre de sexta, sábado e domingo da 00:00 até as 07:00", -25.619359092794305, "Av. Coronel Marcelino E. Freyre", -54.555006920882761, "Crobar (Buenos Aires)", 7, "+54 11 4303-0231" },
                    { 17, "O Café de los Angelitos é um recinto imponente com mais de cem anos de história, por onde desfilaram grandes personalidades do mundo político e artístico de Buenos Aires. Hoje em dia, é palco de um dos mais refinados e elegantes shows de tango da cidade, diversas vezes aclamado pela crítica local.", "/imgpaises/imgArgentina/VidaNoturna/Cafe de los Angelitos  (Buenos Aires).png", "Abre todos os dias das 09:00 até a 11:00", -34.609468927913831, "Rivadavia Ave 2100, corner of Rincon street Balvanera.", -58.396186547487716, "Cafe de los Angelitos  (Buenos Aires)", 7, "+54 11 4952-2320" },
                    { 18, "Vinology é um lugar incrível para se conhecer os bons vinhos da Argentina. É uma vinoteca diferenciada, que tem etiquetas de bodegas especialmente boas, funciona como bar de vinhos com comidinhas deliciosas.", "/imgpaises/imgArgentina/VidaNoturna/Vinology (Buenos Aires).png", "Abre terça, quarta, quinta, sexta e sábado das 14:00 até as 22:00", -34.570552378227354, "República de Eslovenia 1959.", -58.434845818652846, "Vinology (Buenos Aires)", 7, "+54 9 11 3100-2433" },
                    { 19, "A Catedral Metropolitano de Buenos Aires é a principal igreja católica em Buenos Aires, capital da Argentina. Localiza-se no centro da cidade, diante da Praça de Maio, na esquina das ruas San Martín e Rivadavia, no bairro de San Nicolás. É a igreja-mãe da Arquidiocese de Buenos Aires", "/imgpaises/imgArgentina/Fe/Catedral Metropolitana de Buenos Aires (Buenos Aires).png", "De segunda a sexta das 7:30 até as 18:45 e de final de semana das 9:00 até as 18:45.", -34.607366271427303, "San Martín 27, C1004", -58.373300318651069, "Catedral Metropolitana de Buenos Aires (Buenos Aires)", 7, "+54 11 4303-0231" },
                    { 20, "A Basílica Menor de Nossa Senhora de Luján é uma igreja católica romana em Luján, Buenos Aires, Argentina. Construída em estilo neogótico, é dedicada a Nossa Senhora de Luján, padroeira da Argentina. Muitas pessoas confundem esta igreja com uma catedral.", "/imgpaises/imgArgentina/Fe/Basílica de Nuestra Señora de Luján (Luján).png", "Todos os dias das 9:00 até as 18:00", -34.569093609091354, "San Martín 51.", -58.440208863904218, "Basílica de Nuestra Señora de Luján (Luján)  ", 7, "+54 2323 42-1070." },
                    { 21, "Esta magnífica Basílica Menor, construída em terreno doado por Hernando de Lerma, em 1582, com destaque para as cores poderosas terracota, ouro e marfim que cobrem. Ele pertence à ordem franciscana e foi reconstruído várias vezes após vários incêndios.", "/imgpaises/imgArgentina/Fe/Igreja de San Francisco (Salta).png", "Todos os dias das 8:30 até as 20:30, no Domingo das 8:30 até as 12:00 e das 18:00 até as 21:00", -24.790006713060023, "Córdoba 15", -65.408216490219658, "Igreja de San Francisco (Salta)", 7, "+54 387 512-4311" },
                    { 22, "A Mesquita-Catedral de Córdova oficialmente conhecida pelo seu nome eclesiástico, a Catedral de Nossa Senhora da Assunção em espanhol: Catedral de Nuestra Señora de la Asunción é a catedral da Diocese Católica Romana de Córdoba dedicada à Assunção de Maria e localizado na região espanhola da Andaluzia.", "/imgpaises/imgArgentina/Fe/Catedral de Córdoba (Córdoba).png", "De segunda até sábado das 8:30 até as 9:30", -28.470207963157378, "C. Cardenal Herrero, 1, Centro. ", -65.355297713215961, "Catedral de Córdoba (Córdoba)", 7, "+34 957 47 0512. " },
                    { 23, "A Basílica do Santísimo Sacramento é uma das igrejas mais bonitas de Buenos Aires. O templo luxuosamente decorado apresenta uma grande custódia de ouro e prata, vitrais importantes e ornamentos de mármore, granito azul, bronze e mosaico veneziano.", "/imgpaises/imgArgentina/Fe/Basílica del Santísimo Sacramento (Buenos Aires).png", "Quarta-feira, 11:00–13:00, 18:00–20:00, quinta-feira, 11:00–13:00, 18:00–20:00, sexta-feira, 11:00–13:00, 18:00–20:00, sábado, 18:30–20:00, domingo, 09:00–12:30, 17:30–20:30, segunda-feira, 11:00–13:00, 18:00–20:00, terça-feira, 11:00–13:00, 18:00–20:00.", -34.59546334232072, "San Martín 1035.", -58.374236537711141, "Basílica del Santísimo Sacramento (Buenos Aires)", 7, "+54 11 4311-0391." },
                    { 24, "A Catedral de San Carlos de Bariloche é o principal templo católico da cidade de San Carlos de Bariloche, na Argentina. Encontra-se na interseção das ruas Almirante Ou’Connor e Beschtedt, rodeada por duas praças com formosos jardins. É a sé episcopal da Diocese de Bariloche, sufragânea da Arquidiocese de Bahía Blanca.", "/imgpaises/imgArgentina/Fe/Catedral de Nuestra Señora del Nahuel Huapi (Bariloche).png", "De segunda a sexta das 9:00 até as 12:00 e das 17:00 até 21:00.", -41.132911817802359, "Vice Almte. O'Connor 500.", -71.302346445305488, "Catedral de Nuestra Señora del Nahuel Huapi (Bariloche)", 7, "+54 294 443-4084 " },
                    { 25, "Reservar uma mesa no restaurante Don Julio já virou uma atração turística imperdível em Buenos Aires. Os reconhecimentos ajudam: é atualmente o restaurante argentino mais bem colocado entre os 50 melhores do mundo e foi eleito neste ano como a melhor casa de carnes do mundo. As filas que se formam na porta todos os dias são outro medidor do sucesso.", "/imgpaises/imgArgentina/Restaurantes/Don Julio (Buenos Aires).png", "Abre todos os dias das 11:30 até as 16:00 e depois das 19:00 até as 1:00", -34.586136385015543, "Calle Guatemala 4699 Palermo Viejo", -58.424247618652103, "Don Julio (Buenos Aires)", 7, "+54 11 4832-6058" },
                    { 26, "O La Cabrebra é especialista em cortes de carnes, acompanhamentos saborosos e, claro, com muita fartura. É mais um restaurante que figura entre os melhores de Buenos Aires, pelo atendimento, pelo ambiente clássico e pela qualidade das carnes. Nove entre dez brasileiros que visitam a capital, fazem questão de passar no La Cabrera e aproveitar o almoço, happy hour ou jantar.", "/imgpaises/imgArgentina/Restaurantes/La Cabrera (Buenos Aires).png", "Domingo das 12:30 até as 16:00, Segunda das 11:30 até as 16:00 e das 6:30 até as 12:30, de terça, quarta e quinta das 6:30 até as 12:30 e de sexta e sábado das 12:30 até as 16:00 e das 6:30 até as 1:00.", -34.588799061101504, "Jose Antonio Cabrera 5099 Palermo.", -58.433254445632251, "La Cabrera (Buenos Aires)", 7, "+54 11 5586-1435." },
                    { 27, "A poucos minutos do centro - na Bodega Escorihuela -, o elegante 1884, chefiado por Francis Mallmann, carrega a fama de ser o melhor restaurante da cidade. Se não for o melhor, certamente está na lista dos imperdíveis.O ambiente é refinado e clássico, com salões externos e internos. A culinária, tipicamente portenha, vai das empanadas aos melhores cortes de carne.", "/imgpaises/imgArgentina/Restaurantes/1884 Restaurante Francis Mallmann (Mendonza).png", "De terça até Domingo das 19:00 até as 21:30", -32.912124294242354, "Calle Gral Manuel Belgrano 1188", -68.84302357268902, "1884 Restaurante Francis Mallmann (Mendonza)", 7, "+54 261 424-2698" },
                    { 28, "O Oviedo é o restaurante mais tradicional de Buenos Aires quando o assunto é peixe! Os pescados servidos no restaurante estão sempre super frescos, pois o restaurante recebe mercadoria duas vezes ao dia, além disso toda matéria prima servida é de altíssima qualidade e fresca, o que garante um prato muito mais saboroso! O que achamos incrível é que tudo que sai da cozinha parece verdadeira obra de arte, isto porque o chef Martin Rebaudino estudou belas artes para deixar seus pratos mais bonitos e também chegou a trabalhar no El Bulli.", "/imgpaises/imgArgentina/Restaurantes/Oviedo (Rosário).png", "De terça até Sábado das 10:30 até as 20:00.", -32.95622585219165, "C. Jovellanos, 2.", -60.646887162330877, "Oviedo (Rosário)", 7, "+34 984 03 40 14" },
                    { 29, "Entre pescados, massas e assados, bem elaborados em um ambiente simples e elegante, você percorrerá um longo e saboroso caminho pelo melhor da comida argentina.", "/imgpaises/imgArgentina/Restaurantes/Siete Cocinas (Salta) melhorado.png", "De Segunda até Sábado das 20:00 até as 00:00.", -3.4876976206541679, "Av. Bartolomé Mitre 794, na cidade de Mendoza, Argentina.", -76.512734033055366, "Siete Cocinas (Salta)", 7, "+34 984 03 40 14." },
                    { 30, "Estabelecimento é um omakase de carnes com reservas disputadas. Com uma recepção acolhedora no bairro de Palermo Viejo, em Buenos Aires, o Fogón Asado é um omakase de carnes que oferece uma experiência de 10 passos (US$ 80). Para ir ao Fogón é preciso estar com fome, pois os 10 tempos são substanciosos.", "/imgpaises/imgArgentina/Restaurantes/Fogón Asado (Buenos Aires).png", "Todos os dias das 7:45 até as 10:30, apenas de segunda das 7:45 até as 10:00.", -34.588292242050649, "Uriarte 1423.", -58.433711081236453, "Fogón Asado (Buenos Aires)", 7, "+54 11 2142-2936." },
                    { 31, "Museo Nacional de Bellas Artes. O Museu exibe mais de 40 pinturas a óleo e aquarelas do artista, 200 anos após seu nascimento. A exposição reúne cerca de 90 pinturas, desenhos e documentos dos primeiros anos da carreira de Jorge Gumier Maier (1953-2021).", "/imgpaises/imgArgentina/Cultura/Museu Nacional de Belas Artes (Buenos Aires).png", "De terça até domingo das 11:00 até as 20:00", -34.583821545841701, "Av. del Libertador 1473", -58.3930473186523, "Museu Nacional de Belas Artes (Buenos Aires)", 7, "+54 11 5288-9900" },
                    { 32, "Conheça o Museu de Arte Latino Americana (MALBA) de Buenos Aires. Localizado no famoso bairro Palermo, o MALBA é um dos melhores museus em Buenos Aires. Ele tem a intenção de promover a arte da América Latina a partir do século 20, e por isso lá você vai encontrar desdes artistas famosos e renomados, até aqueles mais novos que ainda estão buscando seu espaço no meio artístico. Confira abaixo mais informações sobre o Museu de Arte Latino Americana. ", "/imgpaises/imgArgentina/Cultura/Museu de Arte Latino-Americana de Buenos Aires (MALBA) (Buenos Aires).png", "Abre todos os dias menos de Terça das 11:00 até as 20:00", -34.576721381506999, "Av. Pres. Figueroa Alcorta 3415.", -58.403494562835725, "Museu de Arte Latino-Americana de Buenos Aires (MALBA) (Buenos Aires)", 7, "+54 11 4808-6500" },
                    { 33, "O Museu de Belas Artes de Córdoba é um museu de arte estatal localizado na cidade espanhola de Córdoba. ", "/imgpaises/imgArgentina/Cultura/Museu de Arte Pré-Colombiana e Arte Popular (Córdoba).png", "De terça até Domingo das 9:00 até as 21:00 e excessão de do Domingo das 9:00 até as 15:00.", -40.282323877798703, "Pl. del Potro, 1, Centro.", -5.1797556490995014, "Museu de Arte Pré-Colombiana e Arte Popular (Córdoba)", 7, "+34 957 01 58 58." },
                    { 34, "O museu apresenta em torno de 3.000.000 de objetos em sua coleção, e só uma pequena parte dos mesmos se encontram em exibição. Em grande parte, o prestígio do museu descansa em sua coleção de grandes mamíferos fósseis dos pampas sul-americanos das eras Terciária e Quaternária. Também se destacam as coleções de trilobites do período Cambriano e de graptólitos do período Silúrico da Argentina. O museu conta também com salas de Zoologia, Entomologia, e Botânica.", "/imgpaises/imgArgentina/Cultura/Museu de La Plata (La Plata).png", "De Quarta até Domingo das 10:00 até as 18:00.", -34.579509537505956, "Paseo del Bosque s/n.", -58.405005476325684, "Museu de La Plata (La Plata)", 7, "+54 221 425-7744." },
                    { 35, "O Ocupam um importante edifício construído na década de 1920. O Museo de Bellas Artes dedica-se à exposição de uma importante coleção de pintura argentina do final do século XIX ao XX. Já o MAC conta com 6 salas de exposições e possui um grande terraço e jardins que circundam o edifício, onde regularmente se programam concertos, espetáculos, peças de teatro, entre outros.", "/imgpaises/imgArgentina/Cultura/Museu de Arte Contemporânea de Bahía Blanca (Bahía Blanca).png", "De Segunda até Quinta das 9:00 até as 13:00, sexta das 13:00 até as 17:00 e Domingo das 16:00 até as 20:00.", -38.712929512680304, "Sarmiento, 450", -62.262232545431239, "Museu de Arte Contemporânea de Bahía Blanca (Bahía Blanca)", 7, "+54 221 425-7744" },
                    { 36, null, "/imgpaises/imgArgentina/Cultura/Museu de História Nacional (Rosário).png", "O museu, que primeiro foi chamado Museo Histórico de la Capital, foi criado pelo Intendente Francisco Seeber em 24 de maio de 1889. Adolfo Carranza foi designado diretor do museu que só seria inalgurado no dia 15 de fevereiro de 1891, em um terreno pertencente ao governo nacional. Parte da coleção provinha de descendentes dos homens importantes da Revolución de Maio e da Guerra de Independência, com os quais Carranza tinha se comunicado para pedir-lhes que doassem. A outra parte provinha do Museo Público, instituição formada em 1822 por Bernardino Rivadavia que por disposições oficiais viu-se obrigada a doar os objetos.", -34.626801747395518, "Av. Dr. Eduardo María Gallo s/n.", -58.370546287957147, "Museu de História Nacional (Rosário)", 7, "+54 221 425-7744" },
                    { 37, "O Parque Nacional de Everglades é um parque nacional norte-americano localizado no estado da Flórida, e que serve de proteção a 20% da área original de Everglades. Nos Estados Unidos, é a maior zona tropical, e a maior de qualquer tipo a este do rio Mississipi, e recebe uma média de um milhão de visitantes por ano.", "/imgpaises/imgEUA/Natureza/Parque Evergales (Flórida);.png", "Todos os dias das 9 =00 até 17 =00", -25.306024577107607, "Flórida", -80.892829236170471, "Parque Evergales (Flórida)", 2, "+1 305-242-7700" },
                    { 38, "O Zoológico do Bronx é um famoso zoológico localizado no Bronx Park, no Bronx, em Nova Iorque. É o maior zoológico urbano dos Estados Unidos, compreende 107 hectares de parques e habitações naturais às margens do rio Bronx. O Zoológico do Bronx está situado ao sul do Jardim Botânico de Nova Iorque.", "/imgpaises/imgEUA/Natureza/Zoológico do Bronx (NY);.png", "Todos os dias das 10 =00 até 16 =30", -40.850384965677847, "2300 Southern Blvd", -73.876850446023212, "Zoológico do Bronx (NY)", 2, "+1 718-220-5100" },
                    { 39, "O Parque Nacional de Yellowstone é um parque nacional norte-americano localizado nos estados de Wyoming, Montana e Idaho. É o mais antigo parque nacional no mundo, e um marco na história das áreas protegidas. Foi inaugurado a 1 de março de 1872 e cobre uma área de 8 980 km², estando a maior parte dele no condado de Park, no noroeste do Wyoming. O parque é famoso por, entre outras atrações, seus gêiseres, suas fontes termais e por sua variedade de vida selvagem, na qual incluem-se ursos mansos, lobos, bisontes, alces, e outros animais. É o centro do grande ecossistema de Yellowstone, que é um dos maiores ecossistemas de clima temperado ainda restantes no planeta. O gêiser mais famoso do mundo, denominado Old Faithful, encontra-se neste parque. A cidade mais próxima do parque Yellowstone é Billings, Montana.", "/imgpaises/imgEUA/Natureza/Yellowstone (Wyoming);.png", "Todos os dias 24h", -44.654356927387575, "Wyoming 82190", -110.56717507431897, "Yellowstone (Wyoming)", 2, "+1 718-220-5100" },
                    { 40, "O Zoológico de San Diego é um zoológico em Balboa Park, San Diego, Califórnia, que abriga mais de 3 700 animais de mais de 650 espécies e subespécies.Sua organização mãe, a San Diego Zoo Global, é a maior associação zoológica do mundo, com mais de 250 mil famílias membros e 130 mil crianças afiliadas, representando mais de meio milhão de pessoas. O Zoológico de San Diego foi pioneiro no conceito de exibições ao ar livre sem jaulas que recriam habitats naturais dos animais. Ele é um dos poucos zoológicos no mundo que abriga o panda-gigante. Em 2013, o zoológico incluiu uma nova Koalafornia Adventure, oferecendo uma experiência australiana.", "/imgpaises/imgEUA/Natureza/Zoológico de San Diego (California).png", "De Segunda até Domingo das 9 =00 até as 17 =00", -32.73666104361093, "2920 Zoo Dr", -117.15086363584145, "Zoológico de San Diego (California)", 2, "+1 619-231-1515" },
                    { 41, "O Parque Nacional do Grand Canyon, no Arizona, engloba grande parte do imenso Grand Canyon, com as formações de rocha vermelha em camadas, que revelam milhões de anos de história geológica. Os miradouros incluem Mather Point, a estação de observação de Yavapai e o Lookout Studio e a Torre de Vigia Desert View, da arquiteta Mary Colter. Lipan Point permite vistas amplas do desfiladeiro e do rio Colorado e é popular, sobretudo ao nascer e pôr-do-sol.", "/imgpaises/imgEUA/Natureza/Grand Canyon (Arizona);.png", "De Segunda até Domingo das 7 =00 até as 19 =00", -36.101900665621827, "Arizona 86023", -112.11293869457225, "Grand Canyon (Arizona)", 2, "(928) 638-7888" },
                    { 42, "A fresca e nevoenta floresta Hoh abriga uma incrível variedade de árvores. O bordo e o amieiro são comuns, mas são as altas coníferas que dominam a paisagem. Entre as mais altas estão os pinheiros e os abetos, inclusive o que é conhecido como abeto de Douglas. Essas árvores gigantescas atingem até 90 metros de altura, e seus troncos chegam a medir 6 metros de diâmetro. Caminhe por uma das trilhas bem sinalizadas que há sob esses gigantes de centenas de anos de idade.", "/imgpaises/imgEUA/Natureza/Trilha Hoh Rain Forest (Washington).png", "Todos os dias 24h", -47.860763188462869, "821 Main Ave, Forks, WA 98331", -123.9347339963421, "Trilha Hoh Rain Forest (Washington)", 2, "(360) 373-4400" },
                    { 43, "O Grove, ou Bosque, é encantador. Muito além de um simples shopping, o espaço é ótimo para passear ao ar livre. A praça central, coberta de grama, fontes, coretos, pontes e árvores, é um convite a relaxar em meio à confusão de Los Angeles. ", "/imgpaises/imgEUA/Compras/The Grove (Los Angeles).png", "Sábado e sexta, 10 =00–22 =00/ domingo, 11 =00–20 =00/ segunda-feira e terça, 10 =00–21 =00/ quarta-feira e quinta, 10 =00–21 =00", -34.072249556862126, "189 The Grove Dr, Los Angeles", -118.35749003148823, "The Grove (Los Angeles)", 2, "+1 323-900-8080" },
                    { 44, "Entre as diversas atrações na região do Chelsea, o charmoso mercado gastronômico Chelsea Market é o que mais chama atenção dos turistas. Inaugurado em 1997, antes funcionava a antiga fábrica da Nabisco, onde a bolacha Oreo foi inventada e produzida. No térreo do prédio você vai encontrar 59 lojas e restaurantes, nos andares superiores do edifício estão as sedes de grandes empresas como Google, YouTube, EMI Music, MLB.com entre outras grandes empresas.", "/imgpaises/imgEUA/Compras/Chelsea Market (Nova York).png", "Todos os dias das 08 =00 até as 21 =00", -40.742772546354566, "75 9th Ave, New York", -74.006135817188252, "Chelsea Market (Nova York)", 2, "+1 212-652-2111" },
                    { 45, "Disney Springs, antigamente chamada de Downtown Disney é um centro de compras, restaurantes, teatro e outros tipos de entretenimento pertencente à Walt Disney Company e localizado no complexo Walt Disney World. Situa-se na cidade de Bay Lake, Flórida, próxima de Orlando.", "/imgpaises/imgEUA/Compras/Disney Springs (orlando).png", "Todos os dias das 10 =00 até as 11 =00", -28.371019076866045, "1486 Buena Vista Dr, Lake Buena Vista", -81.519338375440157, "Disney Springs (orlando)", 2, "+1 407-939-5277" },
                    { 46, "Esteja você procurando móveis novos para renovar sua casa ou uma bicicleta novinha em folha para levá-lo do ponto A ao ponto B, você pode fazer todas as suas compras em uma viagem fácil ao Walmart. De brinquedos e videogames a roupas da moda e sapatos combinando para toda a família, sua Albany Walmart Superstore tem de tudo.", "/imgpaises/imgEUA/Compras/Walmart (Albany, NY).png", "Todos os dias das 06 =00 até as 23 =00", -42.695435507788332, "141 Washington Ave Ext, Albany", -73.84711562526202, "Walmart (Albany, NY)", 2, " +1 518-869-4694" },
                    { 47, "Aventura Mall é um shopping localizado em Aventura, Flórida. É o terceiro maior shopping dos Estados Unidos em metros quadrados totais de área de varejo e o maior shopping da Flórida. O shopping oferece JCPenney, Macy's, Nordstrom e Bloomingdale's, além de cinemas AMC com 24 telas.", "/imgpaises/imgEUA/Compras/Aventura Mall (Mimi).png", "Todos os dias das 10 =00 até as 21 =30", -25.957219503652013, "19501 Biscayne Blvd, Aventura", -80.14270392930834, "Aventura Mall (Miami)", 2, "+1 305-935-1110" },
                    { 48, "Criada à imagem e semelhança da Macy's, uma das mais antigas e importantes rede de lojas de departamento dos EUA, a Neiman Marcus foi fundada em 1907, no Texas, e rapidamente se tornou uma das redes mais badaladas do mercado americano.", "/imgpaises/imgEUA/Compras/Neiman Marous(Dallas).png", "De segunda até sábado das 10 =00 até as 20 =00 e de domingo das 12 =00 até as 18 =00", -32.781221608950943, "8687 N Central Expy, Dallas", -96.79715947107249, "Neiman Marcous(Dallas)", 2, "+1 214-363-8311" },
                    { 49, "Ótima balada, casa muito bonita e bem frequentada. Local animado e as atrações agitam bastante o público. Uma das melhores boates que já fui em NY. Noite super animada, pessoas bonitas e simpáticas de todos os cantos do mundo.", "/imgpaises/imgEUA/VidaNoturna/Marquee Nightclub (Nevada).png", "Abre de Domingo, quarta, sexta e sábado das 22 =00 até as 04 =00", -36.110120026710511, "Located Inside the Cosmopolitan, 3708 S Las Vegas Blvd, Las Vegas, NV 89109", -115.174144496593, "Marquee Nightclub (Nevada)", 2, "+1 702-333-9000" },
                    { 50, "O Varnish foi inaugurado em 2009 e recebeu elogios, incluindo o Melhor Bar Americano do Spirited Awards e um lugar na lista dos 50 Melhores Bares do Mundo. Mesmo com sua pequena lista de coquetéis práticos de estilo clássico, o bar conseguiu permanecer no radar de todos os bebedores de Los Angeles, durante toda a moda do farm-to-glass, o movimento de mixologia molecular e até mesmo o atual frenesi do brilho do Instagram. O Varnish foi inaugurado em 2009 e recebeu elogios, incluindo o Melhor Bar Americano do Spirited Awards e um lugar na lista dos 50 Melhores Bares do Mundo. Mesmo com sua pequena lista de coquetéis práticos de estilo clássico, o bar conseguiu permanecer no radar de todos os bebedores de Los Angeles, durante toda a moda do farm-to-glass, o movimento de mixologia molecular e até mesmo o atual frenesi do brilho do Instagram. ", "/imgpaises/imgEUA/VidaNoturna/The Varnish (Los Angeles).png", "Abre todos os dias das 19 =00 até as 02 =00", -34.044980321702639, "118 E 6th St, Los Angeles, CA 90014 ", -118.24956176438316, "The Varnish (Los Angeles)", 2, "+1 213-265-7089" },
                    { 51, "O Acessos muito práticos, wc em excelentes condições e sempre limpos. Zona de fumadores ao livre. Grande variedade de bebidas e acesso à area de merchandise. Excelente para concertos.", "/imgpaises/imgEUA/VidaNoturna/House Of Blues (Boston).png", "Abre todos os dias das 16 =00 até as 22 =00 e de quarta feira das 16 =00 até as 23 =00", -42.34763475441212, "15 Lansdowne St, Boston", -71.095731202108496, "House Of Blues (Boston)", 2, "+1 888-693-2583" },
                    { 52, "O Acessos muito práticos, wc em excelentes condições e sempre limpos. Zona de fumadores ao livre. Grande variedade de bebidas e acesso à area de merchandise. Excelente para concertos.", "/imgpaises/imgEUA/VidaNoturna/Lafitte's Blacksmith Shop Bar (Nova Orleans).png", "Abre todos os dias das 16 =00 até as 22 =00 e de quarta feira das 16 =00 até as 23 =00", -29.961427885615436, "15 Lansdowne St, Boston", -90.063491854323487, "Lafitte's Blacksmith Shop Bar (Nova Orleans)", 2, "+1 888-693-2583" },
                    { 53, "O Green Mill é um lendário clube de jazz localizado no bairro de Uptown, em Chicago, Illinois. Fundado em 1907, o Green Mill é conhecido por sua rica história e por ser um dos poucos locais que sobreviveram à era da Lei Seca nos Estados Unidos. O clube era frequentado por gangsters famosos, como Al Capone, e ainda mantém seu charme e atmosfera de época. O Green Mill continua a ser um dos principais destinos para os amantes do jazz em Chicago, apresentando músicos locais e internacionais em um ambiente intimista e acolhedor.", "/imgpaises/imgEUA/VidaNoturna/The Green Mill (Illinois).png", "Abre todos os dias das 16 =00 até as 04 =00", -41.969349346834655, "4802 N Broadway, Chicago, IL 60640, EUA", -87.659967601717611, "The Green Mill (Illinois)", 2, "+1 773-878-5552" },
                    { 54, "O Output era uma casa noturna e clube de música eletrônica localizado em Williamsburg, Brooklyn. Conhecido por sua programação eclética de DJs e artistas internacionais, o Output era um destino popular para os amantes da música eletrônica em Nova York. O clube apresentava um sistema de som de alta qualidade e uma pista de dança espaçosa, criando uma experiência imersiva para os frequentadores. Infelizmente, o Output encerrou suas atividades em 2019, mas deixou uma marca duradoura na cena noturna de Nova York. ", "/imgpaises/imgEUA/VidaNoturna/Output (Brooklyn).png", "Abre todos os dias das 16 =00 até as 04 =00", -40.722395220950709, "74 Wythe Ave, Brooklyn, NY 11249 ", -73.957897614985029, "Output (Brooklyn)", 2, "+1 773-878-5552" },
                    { 55, "A Old North Church é uma igreja missionária episcopal localizada no bairro North End de Boston. A igreja, construída em 1723, é a igreja mais antiga de Boston e um marco histórico nacional. A Old North Church é famosa por seu papel no passeio noturno de Paul Revere em 18 de abril de 1775.", "/imgpaises/imgEUA/Fe/Old Noren Church (Massachussets).png", "Abre todos os dias das 10 =00 até as 17 =00 e de Domingo das 11 =00 até as 12 =00 e das 12 =30 até as 17 =00", -42.445728794694773, "193 Salem St, Boston, MA 02113", -71.315431556068404, "Old Noren Church (Massachussets)", 2, "+1 617-523-6676" },
                    { 56, "A Catedral Nacional de Washington, oficialmente conhecida como Catedral Nacional da Igreja Episcopal de São Pedro e São Paulo, é uma das maiores catedrais do mundo e um marco histórico e arquitetônico importante em Washington, DC. A construção da catedral começou em 1907 e levou várias décadas para ser concluída. A catedral é conhecida por sua arquitetura gótica impressionante, vitrais deslumbrantes e por ser o local de muitos eventos religiosos e culturais significativos. A catedral também abriga uma variedade de artefatos e obras de arte preciosas, tornando-a um local de interesse não apenas para os fiéis, mas também para os entusiastas da história e da arquitetura. ional.", "/imgpaises/imgEUA/Fe/Catedral Nacional De Washignion (Washington).png", "Abre de segunda até sexta das 10 =00 até as 17 =00 e de final de semana das 08 =00 até as 18 =00", -38.930895056961006, "3101 Wisconsin Ave NW, Washington, DC 20016, EUA", -77.070802257613806, "Catedral Nacional De Washignion (Washington)", 2, "(202) 537-6200" },
                    { 57, "A Igreja Batista da 16th Street foi organizada como a Primeira Igreja Batista de Cor de Birmingham em 1873. Foi a primeira igreja negra a se organizar em Birmingham, fundada apenas dois anos antes. As primeiras reuniões foram realizadas em um pequeno prédio na 12th Street com a Fourth Avenue North. Logo foi adquirido um terreno na 3ª Avenida Norte, entre as ruas 19 e 20, para um edifício dedicado. Em 1880, a igreja vendeu aquela propriedade e construiu uma nova igreja no local atual na 16th Street com a 6th Avenue North.", "/imgpaises/imgEUA/Fe/166n Street Baptist (Birmigan).png", "Abre todos os dias da semana das 09 =00 até as 17 =00", -33.55641833007963, "1530 6th Ave N, Birmingham, AL 35203", -86.659249512910677, "166n Street Baptist (Birmigan)", 2, "+1 205-251-9402" },
                    { 58, "San Xavier Del Bac, também conhecida como A Igreja Branca do Deserto, é uma igreja católica histórica localizada na reserva indígena Tohono O odham em Tucson, Arizona. A construção da igreja começou em 1783 e foi concluída em 1797. A igreja é conhecida por sua arquitetura barroca espanhola impressionante, sua fachada branca brilhante e seus detalhes decorativos elaborados. San Xavier Del Bac é um importante local de peregrinação e é considerada uma das igrejas mais bonitas e bem preservadas do sudoeste dos Estados Unidos.", "/imgpaises/imgEUA/Fe/San Xavier Del Bac (Tuuson).png", "Abre todos os dias das 09 =00 até as 16 =00", -32.107457292025003, "1950 W San Xavier Rd, Tucson, AZ 85746", -111.00871185927468, "San Xavier Del Bac (Tuuson)", 2, "(520) 294-2624" },
                    { 59, "A Catedral de São Patrício é a maior catedral católica dos Estados Unidos e um dos marcos mais famosos de Nova York. Construída em estilo neogótico, a catedral é conhecida por suas impressionantes torres e vitrais. A catedral também é conhecida por abrigar o túmulo de muitos arcebispos de Nova York e por sediar eventos religiosos importantes. A catedral é um importante centro de peregrinação e turismo em Nova York, atraindo visitantes de todo o mundo.", "/imgpaises/imgEUA/Fe/São Patricio (NY).png", "Abre todos os dias das 06 =30 até as 20 =45", -40.758775680936296, "5th Ave, New York, NY 10022, EUA", -73.976239987319303, "São Patricio (NY)", 2, "(212) 753-2261" },
                    { 60, "A Trinity Church é uma igreja episcopal localizada no distrito financeiro de Manhattan, em Nova York. Fundada em 1697, a igreja é conhecida por sua arquitetura neogótica impressionante e por sua rica história. A Trinity Church desempenhou um papel importante na história de Nova York e é um marco histórico importante na cidade. Além de ser um local de culto, a igreja também é conhecida por suas atividades comunitárias e de caridade. A igreja também abriga um cemitério histórico onde estão enterradas várias figuras proeminentes da história americana.", "/imgpaises/imgEUA/Fe/Trinity Church (NY).png", "Abre todos de segunda a sexta das 07 =00 até as 18 =00 e de final de semana das 08 =00 até as 16 =00", -40.762896298527053, "75 Broadway, New York, NY 10006", -73.964162514008976, "Trinity Church (NY)", 2, "(212) 602-0800" },
                    { 61, "Longas filas se formam cedo para comprar briskets, carnes suína e outras opções defumadas neste local movimentado.", "/imgpaises/imgEUA/Restaurantes/Franklin Barbeyou (Austin).png", "Abre todos de terça a Domingo das 11 =00 até as 15 =00", -30.270320967819629, "900 E 11th St, Austin, TX 78702", -97.731375783589925, "Franklin Barbeyou (Austin)", 2, "+1 512-653-1187" },
                    { 62, "Joe's Stone Crab é um restaurante icônico localizado em Miami Beach, Flórida. Especializado em frutos do mar, com ênfase especial no caranguejo de pedra, o Joe's é conhecido por sua atmosfera animada e sua comida deliciosa. O restaurante é frequentemente visitado por moradores locais e turistas que buscam uma experiência gastronômica única.", "/imgpaises/imgEUA/Restaurantes/Joe's Stone Crab (Miami Beach).png", "Abre segunda até quinta feira das 11 =00 até as 22 =00, de sexta e sábado abre das 11 =30 as 23 =00 e de Domingo das 11 =30 até as 21 =00", -25.769332721797984, "11 Washington Ave, Miami Beach ", -80.135096830616561, "Joe's Stone Crab (Miami Beach)", 2, "+1 305-673-036" },
                    { 63, "A Lavanderia Francesa é um restaurante requintado de culinária francesa e californiana com três estrelas Michelin. Fundado em 1994 pelo chef Thomas Keller, o restaurante é conhecido por seus menus degustação sazonais, que apresentam ingredientes frescos e da estação.expand_more A Lavanderia Francesa também possui uma extensa carta de vinhos, com mais de 1.000 rótulos de todo o mundo.", "/imgpaises/imgEUA/Restaurantes/French Laundry (Yountville).png", "Abre de terça até sábado das 18 =30 até as 22 =00", -38.404672556142536, "6640 Washington St, Yountville", -122.36513570963119, "French Laundry (Yountville)", 2, "+1 707 944 2380" },
                    { 64, "O Per Se é um restaurante requintado de culinária francesa moderna com três estrelas Michelin. Fundado em 2004 pelo chef Thomas Keller, o restaurante é conhecido por seus menus degustação sazonais, que apresentam ingredientes frescos e da estação. O Per Se também possui uma extensa carta de vinhos, com mais de 1.000 rótulos de todo o mundo.", "/imgpaises/imgEUA/Restaurantes/Per Se (NY).png", "Abre de terça até sábado das 17 =30 até as 22 =00", -40.768457156516632, "10 Columbus Cir, New York ", -73.983173481156527, "Per Se (NY)", 2, "+1 212 823 9335" },
                    { 65, "Restaurante simples e espaçoso com buffet de comida brasileira, incluindo ensopados em algumas noites.", "/imgpaises/imgEUA/Restaurantes/Camila's.png", "Abre de segunda a domingo, das 11h até as 23h", -40.761586068137731, "5458 International Dr, Orlando, FL 32819, EUA", -73.981873668491602, "Camilas (Orlando, FL)", 2, "+1 407-354-2507" },
                    { 66, "Comida americana regional, incluindo ostras e frango frito muito elogiado, em um ambiente animado e moderno.", "/imgpaises/imgEUA/Restaurantes/The dutch.png", "Abre de segunda a sexta, das 12h até as 22h, sábado e domingo, das 10h até as 23h", -41.913930000877642, "131 Sullivan St, New York, NY 10012, EUA", -87.648064305446482, "The Dutch (NY)", 2, "+1 212-677-6200" },
                    { 67, "O Independence National Historical Park é um parque histórico nacional que preserva vários locais associados à Revolução Americana e à história da fundação dos Estados Unidos. O parque abriga o Independence Hall, onde a Declaração da Independência e a Constituição dos Estados Unidos foram debatidas e adotadas.", "/imgpaises/imgEUA/Cultura/Independece National Historical Park (Filadelfía).png", "Abre todos os dias das 09 =00 até as 17 =00", -40.499689033471029, "143 S 3rd St, Philadelphia", -75.16705952368153, "Independece National Historical Park (Filadelfía)", 2, "+1 215 965 2300" },
                    { 68, "A Ilha de Alcatraz é uma ilha rochosa localizada na Baía de São Francisco, na Califórnia. A ilha já foi um forte militar, uma prisão federal e agora é um parque nacional. A prisão de Alcatraz é uma das atrações turísticas mais populares de São Francisco.", "/imgpaises/imgEUA/Cultura/Alcatraz Island (São Francisco).png", "Abre todos os dias das 09 =00 até as 17 =00", -32.684029962161411, "Pier 33, Alcatraz Island", -104.26023604562027, "Alcatraz Island (São Francisco)", 2, "+1 415 561 4900" },
                    { 69, "O Museu Nacional dos Direitos Civis é um museu dedicado à história do movimento dos direitos civis nos Estados Unidos. O museu está localizado em Memphis, Tennessee, no local do Lorraine Motel, onde o Dr. Martin Luther King Jr. foi assassinado em 1968.", "/imgpaises/imgEUA/Cultura/National Civil Right Museum (Tenesse).png", "Abre de segunda até sábado das 09 =00 até as 17 =00 e de Domingo das 12 =00 até as 17 =00", -35.134766014551566, "50 Mulberry St, Memphis", -90.057802763134887, "National Civil Right Museum (Tenesse)", 2, "+1 901 521 9699" },
                    { 70, "O Parque Militar Nacional de Gettysburg preserva o campo de batalha da Batalha de Gettysburg, travada de 1 a 3 de julho de 1863, durante a Guerra Civil Americana. A batalha foi a mais sangrenta da guerra e um ponto de virada no conflito. O parque abrange mais de 6.000 acres de campos de batalha, monumentos e memoriais.", "/imgpaises/imgEUA/Cultura/Gettysburg National Military Park (Pensilvania).png", "Abre todos os dias das 08 =00 até as 17 =00", -39.805546709251239, "1195 Baltimore Pike, Gettysburg", -77.242111389495236, "Gettysburg National Military Park (Pensilvania)", 2, "+1 717 334 1124" },
                    { 71, "O Monte Rushmore é um monumento esculpido em uma montanha de granito no estado americano de Dakota do Sul. O monumento apresenta os rostos de quatro presidentes dos Estados Unidos = George Washington, Thomas Jefferson, Theodore Roosevelt e Abraham Lincoln.", "/imgpaises/imgEUA/Cultura/Mount Rushmore (Reystone).png", "Abre todos os dias das 05 =00 até as 00 =00", -43.880668367810038, "13000 S Dakota Hwy 244, Keystone", -103.45386378517119, "Mount Rushmore (Reystone)", 2, "+1 605 574 2523" },
                    { 72, "Pearl Harbor é um porto natural na ilha de Oahu, no Havaí. Foi o local do ataque japonês aos Estados Unidos em 7 de dezembro de 1941, que precipitou a entrada dos Estados Unidos na Segunda Guerra Mundial. O porto abriga agora várias instalações militares, bem como o USS Arizona Memorial, o USS Missouri Memorial e o Pearl Harbor Aviation Museum.", "/imgpaises/imgEUA/Cultura/Pearl Harbour (Havaí).png", "Abre todos os dias das 07 =00 até as 17 =00", -21.356943711342474, "1000 Kamehameha Hwy, Honolulu", -157.98047046158521, "Pearl Harbour (Havaí)", 2, " +1 808-422-3399" },
                    { 73, "O Parque Nacional de Écrins é um parque nacional francês localizado nos Alpes franceses. É o maior parque nacional da França, com uma área de 918.000 hectares. O parque abriga uma variedade de paisagens, incluindo montanhas, geleiras, lagos e florestas. O parque também abriga uma variedade de vida selvagem, incluindo íbex, cabras selvagens, marmotas e aves de rapina.", "/imgpaises/imgFranca/Natureza/Parque Nacional de Ecrins (Alpes Franceses).png", "Abre de Segunda até sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00.", -44.921451548508252, "Maison du Parc, Domaine de Charance.", -6.3358955411469671, "Parque Nacional de Ecrins (Alpes Franceses)", 3, "+33 492235400." },
                    { 74, "O Parc Zoologique de Paris, também conhecido como Zoo de Vincennes, é um parque zoológico localizado no 12º arrondissement de Paris, França. É um dos maiores zoos da Europa, com mais de 2.000 animais de 250 espécies diferentes. O zoo está dividido em cinco biozonas: Patagônia, Europa, Madagascar, Planície Africana e Amazônia-Guiana.", "/imgpaises/imgFranca/Natureza/Parc Zoologique de Paris (Paris).png", "Aberto todos os dias do ano, exceto 25 de dezembro e 1º de janeiro, das 9h30 às 18h (última entrada às 17h15).", -48.833564640873107, "53 Avenue Daumesnil, 75012 Paris.", -2.4144388836045372, "Parc Zoologique de Paris (Paris)", 3, "+33 140729524." },
                    { 75, "O Parc de la Tête d'Or é um parque urbano exuberante e extenso situado no coração de Lyon, França. Com seus 117 hectares de área verde, oferece um refúgio natural para os habitantes da cidade e visitantes, proporcionando uma variedade de atividades para todos os gostos e idades.", "/imgpaises/imgFranca/Natureza/Parc de la Tête d'Or (Lyon).png", "Das 7h às 20h (de novembro a abril) e das 6h30 às 21h (de maio a outubro).", -45.777329376044591, "1 Rue du Premier-Mars 1871, 69006 Lyon.", -4.8549697374029126, "Parc de la Tête d'Or (Lyon)", 3, "+33 472605300." },
                    { 76, "O Parque Natural Regional de Camargue é uma área úmida protegida localizada no sul da França, na região da Provença-Alpes-Costa Azul. O parque abriga uma variedade de paisagens, incluindo pântanos, salinas, dunas e florestas. O parque também é o lar de uma grande variedade de vida selvagem, incluindo flamingos, cavalos selvagens e touros negros.", "/imgpaises/imgFranca/Natureza/Parque Natural Regional de Camargue (Provença-Alpes-Costa Azul).png", "De Segunda a Sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00.", -43.526040379444197, " Maison du Parc, 13200 Arles.", -4.6080163027644625, "Parque Natural Regional de Camargue (Provença-Alpes-Costa Azul)", 3, "+33 4 90974040." },
                    { 77, "O Jardim Botânico de Bordéus é um jardim botânico público com uma área de 11 hectares. Fundado em 1629, é um dos mais antigos jardins botânicos da França. O jardim abriga uma coleção de mais de 3.000 espécies de plantas de todo o mundo, incluindo plantas tropicais, subtropicais e temperadas. O jardim também possui um herbário com mais de 100.000 espécimes de plantas.", "/imgpaises/imgFranca/Natureza/Jardim Botânico de Bordéus  (Bordéus).png", "Das 7h30 às 20h (de abril a setembro) e das 8h às 18h (de outubro a março).", -44.849893732712438, " Rue du Jardin Public, 33000 Bordeaux.", -0.58003333501828502, "Jardim Botânico de Bordéus (Bordéus)", 3, "+33 556524217." },
                    { 78, "O Parc Zoologique de La Palmyre é um zoológico particular com uma área de 18 hectares. Fundado em 1966, é um dos maiores zoológicos da França. O zoológico abriga uma coleção de mais de 1.600 animais de 115 espécies diferentes, incluindo mamíferos, aves, répteis e anfíbios. O zoológico também possui um parque aquático com shows de leões marinhos e focas.", "/imgpaises/imgFranca/Natureza/Parc Zoologique de La Palmyre (Royan).png", "Abre de Segunda até sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00", -45.686120937739126, "Route de Royan, 17570 Les Mathes", -1.1667513390495499, "Parc Zoologique de La Palmyre (Royan)", 3, "+33 5 46 22 46 46" },
                    { 79, "As Halles de Lyon - Paul Bocuse, um mercado gastronômico coberto com mais de 13.000 m², é um dos principais pontos turísticos de Lyon e um paraíso para os amantes da gastronomia. Inaugurado em 1859 e reaberto em 2006 após uma extensa reforma, o mercado recebeu o nome do famoso chef francês Paul Bocuse, um frequentador assíduo e defensor da culinária local.", "/imgpaises/imgFranca/Compras/Les Halles de Lyon - Paul Bocuse (Lyon).png", "De Segunda a sábado das 7h às 22h30 e de Domingo das 7h às 14h30", -45.762886411991381, "102 Cours Lafayette, 69003 Lyon", -4.8502052546052061, "Les Halles de Lyon - Paul Bocuse (Lyon)", 3, "+33 4 72405757" },
                    { 80, "O Centre Commercial Val d'Europe é um dos maiores centros comerciais da Europa, com mais de 190 lojas e 30 restaurantes. Localizado em Marne-la-Vallée, a apenas 5 minutos de Disneyland Paris, o centro comercial é um destino popular para compras, alimentação e entretenimento.", "/imgpaises/imgFranca/Compras/Centre Commercial Val d'Europe (Marne-la-Vallée).png", "De Segunda a sábado das 10h às 20h30 e de Domingo das 10h às 20h", -48.855240036825549, "Boulevard circulaire, 77700 Serris.", -2.7780312394225404, "Val d'Europe", 3, "+33 1 60434040" },
                    { 81, "O Marché de la Bastille é um mercado de rua tradicional que acontece no Boulevard Richard Lenoir, em frente à Place de la Bastille, em Paris. O mercado existe desde o século XIX e é um dos maiores mercados de rua da cidade.", "/imgpaises/imgFranca/Compras/Marché de la Bastille (Paris).png", "De Segunda a sábado das 10h às 20h30 e de Domingo das 10h às 20h", -48.918973789698903, "Boulevard Richard Lenoir, 75011 Paris", -2.3816819888970446, " Marché de la Bastille (Lyon)", 3, "De Quinta-feira das  7h às 14h30 e de Domingo das 7h às 15h" },
                    { 82, "O Parque Nacional de Écrins é um parque nacional francês localizado nos Alpes franceses. É o maior parque nacional da França, com uma área de 918.000 hectares. O parque abriga uma variedade de paisagens, incluindo montanhas, geleiras, lagos e florestas. O parque também abriga uma variedade de vida selvagem, incluindo íbex, cabras selvagens, marmotas e aves de rapina.", "/imgpaises/imgFranca/Compras/Passage Pommeraye (Nantes).png", "Abre de Segunda até sexta das 09:00 às 12:00 e depois das 14:00 até as 18:00.", -47.213677089327831, "Maison du Parc, Domaine de Charance.", -1.5596807029923423, "Passage Pommeraye (Nantes)", 3, "+33 492235400." },
                    { 83, "Les Docks Village é um centro comercial e de lazer localizado no coração de Marselha, na França. O centro comercial está situado em um antigo armazém portuário do século XIX, que foi completamente renovado e modernizado.", "/imgpaises/imgFranca/Compras/Les Docks Village (Marselha).png", "Segunda a sábado das 10h às 20h de Domingo das11h às 19h.", -43.307171894237776, "10 Place de la Joliette, 13002 Marseille ", -5.3662959679717757, "Les Docks Village (Marselha)", 3, "+33 484359090 " },
                    { 84, "O Village Royal é um centro comercial de luxo localizado no coração de Paris, na França. O centro comercial está situado em um antigo convento do século XVII, que foi completamente renovado e modernizado. ", "/imgpaises/imgFranca/Compras/Village Royal (Paris).png", "Segunda a sábado das10h às 20h de Domingo das 11h às 19h ", -48.869512114980303, "2 Rue Royale, 75008 Paris", -2.3223143682599248, "Village Royal (Paris)", 3, "+33 142603131  " },
                    { 85, "Montmartre é um bairro conhecido por sua atmosfera boêmia e artística. A Basílica do Sacré-Coeur, localizada no topo da colina de Montmartre, é um dos principais pontos turísticos do bairro. Outros pontos de interesse incluem o Moulin Rouge, o Museu de Montmartre e a Place du Tertre.  ", "/imgpaises/imgFranca/VidaNoturna/Montmarte e Pigalle (Paris).png", "Todos os dias das 10h até as 18h. ", -48.851109464881631, "75018 Paris, França", -2.344838839643606, "Montmarte e Pigalle (Paris) ", 3, "Não Tem  " },
                    { 86, "La Cité du Vin é um museu cultural e centro de exposições dedicado ao vinho, localizado em Bordeaux, França. Inaugurado em 2016, o museu oferece uma experiência imersiva e sensorial, explorando a história, a produção e o impacto cultural do vinho em todo o mundo.", "/imgpaises/imgFranca/VidaNoturna/La Cité du Vin (Bordeaux).png", "Aberto todos os dias das 10h até as 18h e fechado nos dias 22 a 28 de janeiro. ", -44.862531449636279, "134 Quai de Bacalan, 33000 Bordeaux", -0.55056785893085636, "La Cité du Vin (Bordeaux)   ", 3, "+33 556002020  " },
                    { 87, "L'Usine, em Istres, é mais do que um centro cultural. É um espaço vibrante e acolhedor que pulsa com a energia da cultura e das artes em todas as suas formas. Mais do que um local para eventos, L'Usine é uma comunidade vibrante que conecta artistas, criadores e público em um ambiente único e inspirador. ", "/imgpaises/imgFranca/VidaNoturna/L'Usine (Istres).png", "Aberto de terça até sexta das 14h até as 18h, de sábado das 10h até as 18h e de final de semana fechado.", -43.491535525120298, "442 Rue du 8 Mai 1945, 13800 Istres", -4.9694466968174806, "L'Usine (Istres)", 3, "+33 442560221" },
                    { 88, "Os Grands Boulevards são uma área vibrante e movimentada de Paris, com uma grande variedade de lojas, restaurantes, cafés, teatros e cinemas. A área é um popular destino turístico, especialmente para quem gosta de fazer compras, observar as pessoas e experimentar a cultura parisiense. ", "/imgpaises/imgFranca/VidaNoturna/Grands Boulevards (Paris).png", "Aberto de todos os dias e 24h por dia.", -48.870336834473783, "Boulevard Montmartre, 75008 Paris", -2.3465661888531213, "Grands Boulevards (Paris)", 3, "Não tem" },
                    { 89, "Le Batofar é um barco-clube e sala de concertos flutuante no Rio Sena, em Paris. A embarcação, que já foi um farol holandês, oferece uma experiência única de música ao vivo e DJs em um ambiente descontraído e alternativo. ", "/imgpaises/imgFranca/VidaNoturna/Le Batofar (Paris).png", "Aberto de quarta até sexta 19h até as 2h, de sábado das 12h até as 2h, de Domingo das 12h até as 0h e fechado de segunda e terça. ", -48.833458854372715, "11 Quai Charles Pasqua, 75013 Paris ", -2.3790488970946067, "Le Batofar (Paris)  ", 3, "+33 140405024" },
                    { 90, "A Champs-Élysées é uma das avenidas mais famosas do mundo, conhecida por suas lojas luxuosas, cafés charmosos, monumentos históricos e atmosfera vibrante. É um local popular para turistas e parisienses, oferecendo uma variedade de atividades para todos os gostos.  ", "/imgpaises/imgFranca/VidaNoturna/Champs-Élysées (Paris).png", "Aberto de segunda até sábado das 10h até as 20h. ", -48.873143644833625, "Avenue des Champs-Élysées  ", -2.2978847836067109, "Champs-Élysées (Paris) ", 3, "Não tem" },
                    { 91, "A Catedral de Notre-Dame de Paris é uma das catedrais góticas mais famosas do mundo. Construída entre os séculos XII e XIII, é considerada uma obra-prima da arquitetura gótica e um símbolo da cultura francesa. A catedral é dedicada à Virgem Maria e é um importante local de peregrinação católica.  ", "/imgpaises/imgFranca/Fe/Catedral de Notre-Dame de Paris (Paris).png", "Previsão de reabertura em 2024.", -48.853116420726749, "6 Parvis Notre-Dame - Place Jean-Paul II, 75004 Paris ", -2.3498699105857739, "Catedral de Notre-Dame de Paris (Paris)", 3, "+33 142345610" },
                    { 92, "A Catedral de Chartres é uma catedral gótica francesa considerada Patrimônio Mundial da UNESCO. Construída entre os séculos XII e XIII, é um dos mais belos exemplos da arquitetura gótica e um importante local de peregrinação mariana. ", "/imgpaises/imgFranca/Fe/Catedral de Chartres (Chartres).png", "De segunda até sábado das 8:30h até as 19h e de Domingo e feriados das 12h até as 19h.", -48.447944900267856, "16 Rue Saint-Pierre, 28000 Chartres", -1.487772724053863, "Catedral de Chartres (Chartres)", 3, "+33 237218585" },
                    { 93, "A Basílica de Saint-Denis é uma igreja gótica francesa e necrópole real, considerada Patrimônio Mundial da UNESCO. Construída entre os séculos XII e XIII, é um dos primeiros exemplos da arquitetura gótica e o local de sepultamento de 43 reis e 32 rainhas da França. ", "/imgpaises/imgFranca/Fe/Basílica de Saint-Denis (Saint-Denis).png", "De terça até domingo das 10h até as 18h e fechado de segunda.", -48.935827779995442, "1 Rue de la Légion d'Honneur, 93200 Saint-Denis ", -2.3590846105902665, "Basílica de Saint-Denis (Saint-Denis)", 3, "+33 148098311" },
                    { 94, "A Abadia do Monte Saint-Michel é um mosteiro beneditino e um importante local de peregrinação, situado em uma ilha rochosa na costa da Normandia, França. A abadia foi fundada no século VIII e é um dos exemplos mais notáveis da arquitetura românica e gótica. ", "/imgpaises/imgFranca/Fe/Abadia de Mont Saint-Michel (Mont Saint-Michel).png", "Em 1º de abril a 30 de setembro: 9h às 19h e em 1º de outubro a 31 de março: 9h30 às 18h. ", -48.636041951889453, "50170 Le Mont-Saint-Michel  ", -1.511686858732928, "Abadia de Mont Saint-Michel (Mont Saint-Michel) ", 3, "+33 233601414" },
                    { 95, "A Catedral de Saint-Pierre de Beauvais é uma catedral gótica francesa, considerada Patrimônio Mundial da UNESCO. Começada no século XIII, é a catedral mais alta da França e a segunda mais alta do mundo, com coro a 48,5 metros de altura. A catedral é um importante local de peregrinação mariana.  ", "/imgpaises/imgFranca/Fe/Catedral de Saint-Pierre de Beauvais (Beauvais).png", "De Segunda a sábado: 9h30 às 12h30 e 14h às 17h30 e de Domingo e feriados: 14h às 17h30.  ", -49.432656500359009, "2 Rue Saint-Pierre, 60000 Beauvais ", -2.0815051989838729, "Catedral de Saint-Pierre de Beauvais (Beauvais)  ", 3, "+33 344481244" },
                    { 96, "A Basílica de Saint-Sernin é uma igreja românica francesa, considerada Patrimônio Mundial da UNESCO. Construída entre os séculos XI e XIII, é a maior igreja românica conservada na Europa e um importante local de peregrinação no Caminho de Santiago.  ", "/imgpaises/imgFranca/Fe/Basílica de Saint-Sernin (Toulouse).png", "De Segunda a sábado: 10h às 12h30 e 14h às 18h e de Domingo e feriados: 14h às 18h.  ", -43.608408792402528, "Place Saint-Sernin, 31000 Toulouse ", -1.4417931679865859, "Basílica de Saint-Sernin (Toulouse)   ", 3, "+33 561223544" },
                    { 97, "A Ladurée é uma confeitaria francesa fundada em 1862, famosa por seus macarons coloridos e deliciosos. A loja da Champs-Élysées é a mais famosa da marca e oferece uma grande variedade de doces, chocolates, chás e outros produtos gourmet.  ", "/imgpaises/imgFranca/Restaurantes/Ladurée (Paris).png", "De Segunda a sábado: 8h às 21h30 e de Domingo: 8h às 20h30.  ", -48.873056174864672, "75 Av. des Champs-Élysées, 75008 Paris ", -2.3025796333903679, "Ladurée (Paris)   ", 3, "+33 140750875" },
                    { 98, "O Bustronome Paris é um restaurante único que oferece uma experiência gastronômica com vista para os principais pontos turísticos da cidade. A bordo de um ônibus de dois andares com teto de vidro, você pode desfrutar de um menu gourmet enquanto aprecia a vista da Torre Eiffel, do Arco do Triunfo, da Catedral de Notre Dame e de muitos outros lugares.  ", "/imgpaises/imgFranca/Restaurantes/Bustronome Paris.png", "Almoço das 12h às 14h30 (segunda a sexta), Jantar das 19h às 22h30 (todos os dias) e o Cruzeiro com brunch das 11h às 14h (sábado e domingo)  ", -48.872907905401561, "2 Avenue Kléber, 75016 Paris ", -2.2938622394235009, "Bustronome Paris (Paris)  ", 3, "+33 142891919" },
                    { 99, "A La Crêperie de la Dentellière é uma creperia tradicional francesa localizada na charmosa cidade medieval de Dinan. A creperia oferece uma grande variedade de crepes doces e salgados, feitos com ingredientes frescos e de alta qualidade. ", "/imgpaises/imgFranca/Restaurantes/La Crêperie de la Dentellière (Dinan).png", "Terça a sábado das 12h às 14h e depois das 19h às 21h30, de Domingo das 12h às 14h e Fechado de Segunda-feira  ", -48.453553155418049, "5 Rue de la Croix, 22100 Dinan ", -2.0439927105992979, "La Crêperie de la Dentellière (Dinan)   ", 3, "+33 296334448" },
                    { 100, "Le Petit Nice é um restaurante com estrela Michelin, situado em uma bela vila à beira-mar em Marselha. O restaurante oferece uma vista deslumbrante da Baía de Marselha e do Château d'If. A cozinha é comandada pelo chef Gérald Passedat, que utiliza ingredientes frescos e sazonais do Mediterrâneo para criar pratos inovadores e saborosos.  ", "/imgpaises/imgFranca/Restaurantes/Le Petit Nice (Marseille).png", "No Almoço das 12h às 14h (terça a sexta), no Jantar das 19h às 22h (terça a sexta) e no Fim de semana: Aberto para almoço e janta  ", -43.280218453076508, "Corniche Kennedy, 13007 Marseille ", -5.3520785814605691, "Le Petit Nice (Marseille)    ", 3, "+33 491592592" },
                    { 101, "A Maison de la Truffe é uma loja especializada em trufas, localizada na charmosa cidade de Sarlat-la-Canéda, na região da Dordonha, na França. A loja oferece uma grande variedade de produtos à base de trufas, incluindo trufas frescas, conservas, óleos, cremes e chocolates.   ", "/imgpaises/imgFranca/Restaurantes/Maison de la Truffe (Sarlat-la-Canéda).png", "De Segunda a sábado das 9h30 às 12h30 e depois das 14h30 às 19h e de  Domingo das 10h às 12h30 e  depois 14h30 às 18h. ", -44.881685704518667, "45 Rue de la République, 24200 Sarlat-la-Canéda ", -1.2171629257235212, "Maison de la Truffe (Sarlat-la-Canéda)", 3, "+33 553312494" },
                    { 102, "O Chez Dumonet é um restaurante tradicional francês, localizado no charmoso bairro de Montmartre em Paris. O restaurante oferece uma atmosfera acolhedora e um menu clássico de pratos franceses, como confit de canard, boeuf bourguignon e ratatouille. ", "/imgpaises/imgFranca/Restaurantes/Chez Dumonet (Paris).png", "De Segunda a sexta das 12h30 às 14h30 e depois das 19h30 às 22h30, de Sábado das12h30 às 14h30 e depois 19h30 às 23h e de Domingo: Fechado", -48.845966883956621, "9 Rue Notre Dame de Lorette, 75009 Paris", -2.3198274817487001, "Chez Dumonet (Paris)", 3, "+33 145485794" },
                    { 103, "O Palácio de Versalhes é um dos maiores e mais opulentos palácios do mundo. Foi a residência oficial dos reis da França de 1682 a 1789 e é um símbolo do poder e da riqueza da monarquia francesa. O palácio está situado em uma vasta propriedade que inclui jardins, parques e florestas.  ", "/imgpaises/imgFranca/Cultura/Palácio de Versalhes (Versalhes).png", "De Terça a domingo das 9h às 18h30 (última entrada às 18h) e Fechado de Segundas-feiras, 1º de janeiro, 1º de maio e 25 de dezembro ", -48.805027395635562, "Place d'Armes, 78000 Versailles ", -2.1203124817464847, "Palácio de Versalhes (Versalhes) ", 3, "+33 130837800" },
                    { 104, "A Torre Eiffel é um dos monumentos mais emblemáticos do mundo. Construída em 1889 para a Exposição Universal, a torre é uma estrutura de ferro forjado com 324 metros de altura. A Torre Eiffel oferece uma vista panorâmica de Paris e é um dos pontos turísticos mais visitados do mundo.   ", "/imgpaises/imgFranca/Cultura/Torre Eiffel (Paris).png", "Elevador ao 2º andar das 9h às 23h45 (de setembro a junho) / 9h à 0h45 (de julho a agosto), Elevador ao topo das 9h15 às 23h15 (de setembro a junho) / 9h15 à 0h15 (de julho a agosto) e Escadas das 9h às 23h (de setembro a junho) / 9h às 0h (de julho a agosto)  ", -48.858574774480203, "Champ de Mars, 5 Avenue Anatole France, 75007 Paris ", -2.2944383817494232, "Torre Eiffel (Paris) ", 3, "+33 892701239" },
                    { 105, "A Abadia do Monte Saint-Michel é uma abadia beneditina medieval localizada na ilha rochosa de Mont Saint-Michel, na Normandia, França. A abadia foi fundada no século VIII e é um importante local de peregrinação. A abadia é um Patrimônio Mundial da UNESCO e um dos monumentos mais visitados da França.   ", "/imgpaises/imgFranca/Cultura/Abadia do Monte Saint-Michel (Mont Saint-Michel).png", "Aberto de Abril a setembro das 9h às 19h (última entrada às 18h), Outubro a março das 9h30 às 18h (última entrada às 17h) e Fechado das 1º de janeiro, 1º de maio e 25 de dezembro ", -48.636134122358541, "Place Saint-Michel, 50170 Le Mont-Saint-Michel ", -1.5117297740794853, "Abadia do Monte Saint-Michel (Mont Saint-Michel)  ", 3, "+33 233601414" },
                    { 106, "O Museu Picasso é um museu de arte em Paris, França, dedicado à obra de Pablo Picasso. O museu está situado no Hôtel Salé, uma mansão do século XVII no Marais. A coleção do museu inclui mais de 5.000 obras de Picasso, incluindo pinturas, esculturas, desenhos e gravuras.  ", "/imgpaises/imgFranca/Cultura/Museu Picasso (Paris).png", "De Terça a sexta das 10h30 às 18h, Sábado e domingo das 9h30 às 18h e Fechado de Segundas-feiras, 1º de janeiro, 1º de maio e 25 de dezembro ", -48.859839181115248, "Hôtel Salé, 5 Rue de Thorigny, 75003 Paris  ", -2.3625479796456488, "Museu Picasso (Paris)  ", 3, "+33 142721000" },
                    { 107, "O Château de Chambord é um dos maiores e mais opulentos castelos do mundo. Foi a residência oficial dos reis da França de 1682 a 1789 e é um símbolo do poder e da riqueza da monarquia francesa. O castelo está situado em uma vasta propriedade que inclui jardins, parques e florestas.  ", "/imgpaises/imgFranca/Cultura/Château de Chambord (Vale do Loire).png", "Aberto todos os dias das 9h às 18h (última entrada às 17h) e Fechado das 25 de dezembro e 1º de janeiro  ", -47.615931820037098, "41250 Chambord  ", -1.5168437951725504, "Château de Chambord (Vale do Loire)  ", 3, "+33 254504000" },
                    { 108, "O Museu de Belas Artes de Lyon é um dos museus de arte mais importantes da França. Fundado em 1801, o museu possui uma vasta coleção de obras de arte que datam da Antiguidade até o século XXI. A coleção inclui pinturas, esculturas, desenhos, gravuras e artes decorativas.   ", "/imgpaises/imgFranca/Cultura/Museu de Belas Artes de Lyon (Lyon).png", "Aberto de Quarta a segunda das 10h às 18h, Sexta das 10h30 às 18h e Fechado de Terças-feiras e feriados  ", -45.767304259530945, "20 Place des Terreaux, 69001 Lyon   ", -4.8335869104222038, "Museu de Belas Artes de Lyon (Lyon)  ", 3, "+33 472101740" },
                    { 109, "Hyde Park é um dos maiores parques do centro de Londres, Inglaterra. É um local popular para caminhadas, piqueniques, passeios de barco e apresentações musicais. O Hyde Park foi criado em 1637 e originalmente era usado como terreno de caça pelo rei Henrique VIII. O parque foi aberto ao público no século XIX e rapidamente se tornou um local popular para os londrinos relaxarem e desfrutarem do ar livre.", "/imgpaises/img Inglaterra/Natureza/Hyde Park - Londres.png", "Todos os dias 24h", -51.507683881237433, "Hyde Park, Londres W2 2UH, Reino Unido", -0.16419937413436145, "Hyde Park - Londres", 4, "+44 20 7298 2000" },
                    { 110, "O Peak District National Park é um parque nacional no condado de Derbyshire, Inglaterra. Foi criado em 1951 e é o primeiro parque nacional da Inglaterra. O parque cobre uma área de 1.437 quilômetros quadrados e é conhecido por suas paisagens montanhosas, incluindo planaltos calcários, vales e cavernas.", "/imgpaises/img Inglaterra/Natureza/Peak District National Park - Derbyshire.png", "Todos os dias 24h", -53.299621214188647, "Peak District National Park Authority, Aldern House, Baslow Road, Bakewell, Derbyshire DE45 1AE, Reino Unido", -1.8018637039512835, "Peak District National Park - Derbyshire", 4, "+44 1726 811911" },
                    { 111, "O Eden Project é um jardim botânico e uma atração educacional localizada em Cornwall, Inglaterra. É a maior estufa do mundo e abriga uma vasta coleção de plantas de todo o mundo. O Eden Project está situado em uma antiga mina de argila da China e foi inaugurado em 2001.", "/imgpaises/img Inglaterra/Natureza/Eden Project - Cornwall.png", "Aberto todos os dias das 9h30 às 18h (última entrada às 16h) e Fechado em 24-25 de dezembro", -50.360517239437605, "Eden Project, Bodelva, Cornwall PL23 0BP, Reino Unido", -4.7447607607623095, "Eden Project - Cornwall", 4, "+44 1726 811911" },
                    { 112, "O Chester Zoo é um jardim zoológico localizado em Chester, Inglaterra. É um dos maiores e mais populares zoológicos do Reino Unido. O zoológico abriga mais de 35.000 animais de mais de 1.200 espécies.", "/imgpaises/img Inglaterra/Natureza/Chester Zoo - Chester.png", "Aberto todos os dias das 10h às 16h (última entrada às 15h)", -53.226508870639726, "Chester Zoo, Upton by Chester, Chester CH2 1LH, Reino Unido", -2.8829742585655649, "Chester Zoo - Chester", 4, "+44 1244 380280" },
                    { 113, "O Lake District National Park é um parque nacional na Cumbria, Inglaterra. É o maior parque nacional da Inglaterra e é conhecido por suas paisagens montanhosas, incluindo lagos glaciais, montanhas acidentadas e associações literárias históricas.", "/imgpaises/img Inglaterra/Natureza/Lake District National Park - Cumbria.png", "Todos os dias 24h", -54.482230808521813, "Brockhole Visitor Centre, Windermere, Cumbria LA23 1LJ, Reino Unido", -3.0713231790123063, "Lake District National Park - Cumbria", 4, "+44 1539 4 08000" },
                    { 114, "O Yorkshire Dales National Park é um parque nacional em Yorkshire, Inglaterra. Foi criado em 1954 e é conhecido por suas paisagens montanhosas, incluindo vales calcários, rios e cachoeiras. O Yorkshire Dales National Park cobre uma área de 2.179 quilômetros quadrados e abriga uma variedade de vida selvagem, incluindo ovelhas, vacas e aves de rapina.", "/imgpaises/img Inglaterra/Natureza/The Yorkshire Dales - Yorkshire.png", "Todos os dias 24h", -54.267415732813603, "Yorkshire Dales National Park Authority, Yoredale House, 60-62 King Street, Leyburn, North Yorkshire DL8 5DT, Reino Unido", -2.0850373612648996, "The Yorkshire Dales - Yorkshire", 4, "+44 1969 640200" },
                    { 115, "O Westfield London é um dos maiores centros comerciais da Europa, com mais de 300 lojas, restaurantes e cafés. Localizado em White City, Londres, o centro comercial é um destino popular para compras, alimentação e entretenimento.", "/imgpaises/img Inglaterra/Compras/Westfield London - Londres.png", "De Segunda a sábado das 10h às 22h e de Domingo das 12h às 18h", -51.508026133587428, "Ariel Way, White City, Londres W12 7GF, Reino Unido", -0.22111961364599422, "Westfield London - Londres", 4, "+44 20 3371 2300" },
                    { 116, "O Bullring & Grand Central é um dos maiores centros comerciais do Reino Unido, com mais de 300 lojas, restaurantes e cafés. Localizado em Birmingham, o centro comercial é um destino popular para compras, alimentação e entretenimento.", "/imgpaises/img Inglaterra/Compras/Bullring - Birmingham.png", "De Segunda a sábado das 10h às 20h e de Domingo das 11h às 17h", -52.477774845046504, "Bullring & Grand Central, Birmingham B5 4BU, Reino Unido ", -1.894371828049406, "Bullring - Birmingham", 4, "+44 121 643 3999" },
                    { 117, "Liverpool ONE é um centro comercial a céu aberto no centro de Liverpool, Inglaterra. É um destino popular para compras, alimentação e entretenimento, com mais de 170 lojas, restaurantes e bares.", "/imgpaises/img Inglaterra/Compras/Liverpool ONE - Liverpool.png", "De Segunda a sábado das 10h às 20h e de Domingo das 11h às 17h", -53.404039570225514, "Liverpool ONE, Liverpool L1 8JQ, Reino Unido  ", -2.986988019189587, "Liverpool ONE - Liverpool", 4, "+44 151 709 7400 " },
                    { 118, "The Lanes é um labirinto de ruas estreitas e sinuosas com lojas, restaurantes, pubs e cafés peculiares. É um destino popular para compras, alimentação e passeios turísticos. ", "/imgpaises/img Inglaterra/Compras/The Lanes - Brighton.png", "Todos os dias 24h", -50.822981477934881, "The Lanes, Brighton BN1 1HB, Reino Unido ", -0.14169086769586531, "The Lanes - Brighton", 4, "+44 151 809 6400" },
                    { 119, "O Cheshire Oaks Designer Outlet é o maior outlet do Reino Unido, com mais de 145 lojas de grife. Localizado em Ellesmere Port, Cheshire, o outlet é um destino popular para compras com descontos de até 60%.", "/imgpaises/img Inglaterra/Compras/Cheshire Oaks Designer Outlet - Ellesmere Port.png", "De Segunda a sábado das 10h às 20h e de Domingo das 10h às 18h ", -53.265790184041869, "Cheshire Oaks Designer Outlet, Ellesmere Port, Cheshire CH65 9JJ, Reino Unido ", -2.8814931346667803, "Cheshire Oaks Designer Outlet - Ellesmere Port", 4, "+44 151 356 5000" },
                    { 120, "O Cabot Circus é um centro comercial coberto em Bristol, Inglaterra. É adjacente a Broadmead, um bairro comercial no centro da cidade de Bristol. A área de desenvolvimento do Cabot Circus contém lojas, escritórios, um hotel, 250 apartamentos e antigamente um cinema. ", "/imgpaises/img Inglaterra/Compras/Cabot Circus - Bristol.png", "De Segunda a sábado das 9h30 às 20h e de Domingo das 11h às 17h ", -51.459029140747006, "Cabot Circus, Bristol BS1 3BH, Reino Unido ", -2.5852566136931094, "Cabot Circus - Bristo", 4, "+44 117 929 4400" },
                    { 121, "O Fabric é uma boate noturna em Londres, Inglaterra, conhecida por sua música eletrônica underground. Fundado em 1999, o clube já foi eleito o melhor clube do mundo pela revista DJ Magazine em várias ocasiões. ", "/imgpaises/img Inglaterra/VidaNoturna/Fabric - Londres.png", "De Sexta-feira das 23h às 6h e de Sábado das 23h às 6h ", -51.520034213945571, "77 Charterhouse Street, Farringdon, Londres EC1M 6HJ, Reino Unido", -0.10261289033996089, "Fabric - Londres", 4, "+44 20 7336 8898 " },
                    { 122, "O Cavern Club é um clube de música ao vivo em Liverpool, Inglaterra, famoso por ser o local onde os Beatles tocaram pela primeira vez em 1961. O clube é um marco histórico e um destino popular para turistas de todo o mundo. ", "/imgpaises/img Inglaterra/VidaNoturna/The Cavern Club - Liverpool.png", "De Segunda a sábado das 10h às 23h e de Domingo das 12h às 22h ", -53.666082181443521, "10 Mathew Street, Liverpool L2 7NA, Reino Unido", -3.0877024993674143, "The Cavern Club - Liverpool", 4, "+44 151 236 9091 " },
                    { 123, "The Haunt é um pub e local de música ao vivo em Brighton, Inglaterra. É conhecido por sua música alternativa e indie, e já recebeu shows de bandas como The Smiths, The Cure e Radiohead. O Haunt possui duas salas: a sala principal e a sala Basement. A sala principal é a maior sala e é onde se apresentam as bandas principais. A sala Basement é uma sala menor que apresenta bandas novas e emergentes. ", "/imgpaises/img Inglaterra/VidaNoturna/The Haunt - Brighton.png", "De Segunda a sábado das 11h às 23h e de  Domingo das 12h às 22h ", -50.820808168557981, "The Haunt, 13-14 North Road, Brighton BN1 1YD, Reino Unido ", -0.13912651345095001, "The Haunt - Brighton", 4, "+44 1273 606 999" },
                    { 124, "O Warehouse Project (WHP) é um dos clubes mais famosos do Reino Unido, conhecido por sua programação de DJs internacionais de música eletrônica underground. O clube fica em Manchester, Inglaterra, e funciona em um antigo armazém convertido, o que contribui para sua atmosfera única. ", "/imgpaises/img Inglaterra/VidaNoturna/The Warehouse Project - Manchester.png", "Varia de acordo com o evento ", -53.475996439379408, "Store Street, Manchester M1 2WD, Reino Unido ", -2.2254673884362859, "The Warehouse Project - Manchester", 4, "+44 161 236 9091" },
                    { 125, "O Thekla é um barco-clube noturno e local de música ao vivo em Bristol, Inglaterra. É um barco de carga convertido que está ancorado no porto de Bristol. O Thekla é conhecido por sua programação eclética de música ao vivo, que inclui bandas indie, DJs de música eletrônica e apresentações de comédia. ", "/imgpaises/img Inglaterra/VidaNoturna/Thekla - Bristol.png", "Varia de acordo com o evento ", -51.449389426852733, "Thekla, Mud Dock, The Grove, Bristol BS1 4RB, Reino Unido ", -2.5940763290433217, "Thekla - Bristol", 4, "+44 117 929 4400" },
                    { 126, "A O2 Academy Birmingham é uma casa de shows em Birmingham, Inglaterra, com capacidade para 3.000 pessoas. É conhecida por sua programação de shows de música ao vivo, que inclui artistas internacionais e nacionais de diversos gêneros musicais. ", "/imgpaises/img Inglaterra/VidaNoturna/O2 Academy - Birmingham.png", "Varia de acordo com o evento ", -51.531277308274007, "O2 Academy Birmingham, 152-154 Broad Street, Birmingham B1 2HT, Reino Unido ", -2.5912643961407835, "O2 Academy - Birmingham", 4, "+44 121 644 4444" },
                    { 127, "A Catedral de Canterbury é uma catedral gótica em Canterbury, Inglaterra. É a sede do Arcebispo de Canterbury, o líder espiritual da Igreja da Inglaterra. A catedral foi fundada em 597 d.C. e é um Patrimônio Mundial da UNESCO. ", "/imgpaises/img Inglaterra/Fe/Catedral de Canterbury (Cantebury).png", "De Segunda a sexta das 9h30 às 17h30, Sábado das 9h30 às 15h30 e de Domingo é Fechado ", -51.280414063213094, "11 The Precincts, Canterbury CT1 2EH, Reino Unido ", -1.0829285014767407, "Catedral de Canterbury - Canterbury", 4, "+44 1227 762 862 " },
                    { 128, "A Catedral de York Minster é uma catedral gótica em York, Inglaterra. É a sede do Arcebispo de York, o segundo líder espiritual mais importante da Igreja da Inglaterra. A catedral foi fundada em 627 d.C. e é um Patrimônio Mundial da UNESCO. A Catedral de York Minster é uma das maiores catedrais góticas da Europa. É um local de peregrinação há séculos e é um dos destinos turísticos mais populares do país. ", "/imgpaises/img Inglaterra/Fe/Catedral de York Minster - York.png", "De Segunda a sábado das 9h30 às 17h30 (última entrada às 16h45) e de Domingo é Fechado ", -53.962757970452664, "Deangate, York YO1 7HH, Reino Unido ", -1.0821780339784322, "Catedral de York Minster - York", 4, "+44 1904 624 429 " },
                    { 129, "A Catedral de Durham é uma catedral normanda em Durham, Inglaterra. É a sede do Bispo de Durham e um Patrimônio Mundial da UNESCO. A catedral foi fundada em 1093 e é considerada um dos melhores exemplos da arquitetura normanda na Europa. ", "/imgpaises/img Inglaterra/Fe/Catedral de Durham - Durham.png", "De Segunda a sexta das 10h às 17h (última entrada às 16h30), Sábado das 9h30 às 17h (última entrada às 16h30) e de Domingo das 12h30 às 14h30 (última entrada às 14h) ", -54.773876067128548, "The Cathedral, College Green, Durham DH1 3EH, Reino Unido ", -1.5760059030534399, "Catedral de Durham - Durham", 4, "+44 191 338 3111" },
                    { 130, "A Catedral de Salisbury é uma catedral gótica em Salisbury, Inglaterra. É conhecida por sua torre de 123 metros de altura, a mais alta do Reino Unido, e por sua bela arquitetura gótica. A catedral foi fundada em 1220 e é considerada um dos melhores exemplos da arquitetura gótica inglesa. ", "/imgpaises/img Inglaterra/Fe/Catedral de Salisbury - Salisbury.png", "De Segunda a sábado das 10h às 17h (última entrada às 16h) e de Domingo é Fechado ", -51.065579976062445, "6 The Close, Salisbury SP1 2EL, Reino Unido ", -1.7974322907751776, "Catedral de Salisbury - Salisbury", 4, "+44 1722 555 123 " },
                    { 131, "A Catedral de St. Paul é uma catedral anglicana em Londres, Inglaterra. É a sede do Bispo de Londres e uma das maiores igrejas do Reino Unido. A catedral foi projetada por Sir Christopher Wren e construída entre 1675 e 1710. A Catedral de St. Paul é um dos edifícios mais emblemáticos de Londres. É um local de grande importância histórica e religiosa, e é um dos destinos turísticos mais populares da cidade.", "/imgpaises/img Inglaterra/Fe/Catedral de St. Paul - Londres.png", "De Segunda a sábado das 8h30 às 16h30 (última entrada às 16h) e fechado de Domingo ", -51.51451252696512, "t. Paul's Churchyard, London EC4M 8AD, Reino Unido", -0.098307728981067419, "Catedral de St. Paul - Londres", 4, "+44 20 7236 4128 " },
                    { 132, "A Catedral de Winchester é uma catedral gótica em Winchester, Inglaterra. É a maior catedral gótica da Europa em termos de área e é um Patrimônio Mundial da UNESCO. A catedral foi fundada em 1079 e é considerada um dos melhores exemplos da arquitetura gótica inglesa. ", "/imgpaises/img Inglaterra/Fe/Catedral de Winchester - Winchester.png", "De Segunda a sábado das 10h às 17h30 (última entrada às 16h45) e de Domingo é Fechado ", -51.061470933444042, "1 The Close, Winchester SO23 9LS, Reino Unido ", -1.313368421461494, "Catedral de Winchester - Winchester", 4, "+44 1962 854 225 " },
                    { 133, "The Sportsman é um pub gastronômico premiado com uma estrela Michelin, situado na vila costeira de Seasalter, em Kent, Inglaterra. É conhecido por sua culinária inovadora e sazonal, que destaca os melhores ingredientes locais. ", "/imgpaises/img Inglaterra/Restaurantes/The Sportsman, Seasalter.png", "De Terça a sábado das 12h às 14h30 e depois das18h30 às 21h30 e de Domingo das 12h às 14h30 e fechado de segunda ", -51.344322448983363, "Faversham Road, Seasalter, Whitstable CT5 4BP, Reino Unido ", -0.95893317085592811, "The Sportsman, Seasalter", 4, "+44 1227 273 370 " },
                    { 134, "O Sketch é um restaurante e bar requintado em Londres, famoso por seu interior luxuoso e sua cozinha inovadora. O restaurante é dividido em vários espaços distintos, cada um com seu próprio tema e atmosfera. ", "/imgpaises/img Inglaterra/Restaurantes/Sketch - Londres.png", "De Segunda a sexta das 12h às 23h30, Sábado das 11h às 23h30 e de Domingo é Fechado ", -51.513199997985957, "9 Conduit Street, Mayfair, Londres W1S 2XG, Reino Unido ", -0.14144321364106205, "Sketch - Londres", 4, "+44 20 7659 8585 " },
                    { 135, "O Gordon Ramsay Bar & Grill é um restaurante elegante e contemporâneo em Edimburgo, com vista para o Castelo de Edimburgo. O restaurante é conhecido por sua cozinha clássica com um toque moderno e por seu serviço impecável. ", "/imgpaises/img Inglaterra/Restaurantes/Gordon Ramsay Bar & Grill - Edimburgo.png", "De Segunda a sexta das 12h às 14h30 e depois das 17h30 às 22h30, Sábado das12h às 22h30 e de Domingo é Fechado ", -51.515654432669805, "50 Queen Street, Edinburgh EH2 3NH, Reino Unido ", -0.15114481223422471, "Gordon Ramsay Bar & Grill - Edimburgo", 4, "+44 131 220 0292 " },
                    { 136, "O The Ivy Manchester é um restaurante elegante e luxuoso em Manchester, situado no histórico Midland Hotel. O restaurante é conhecido por sua cozinha clássica britânica com um toque moderno e por seu ambiente sofisticado. ", "/imgpaises/img Inglaterra/Restaurantes/The Ivy - Manchester.png", "DeSegunda a sexta das 12h às 14h30 e depois das 17h30 às 22h30, Sábado das 12h às 22h30 e Domingo é Fechado ", -51.520937652903115, "The Midland Hotel, 1 Peter Street, Manchester M2 1NQ, Reino Unido ", -0.16384789860905019, "The Ivy - Manchester", 4, "+44 161 235 4444 " },
                    { 137, "O Waterside Inn é um restaurante com três estrelas Michelin em Bray, Berkshire, Inglaterra. É conhecido por sua culinária clássica francesa com um toque moderno e por seu ambiente elegante e sofisticado. O restaurante é comandado pelo chef Alain Roux, que assumiu o comando do restaurante de seu pai, Michel Roux, em 1992. Alain Roux manteve a tradição de excelência do restaurante, e o Waterside Inn continua a ser um dos restaurantes mais aclamados do mundo. ", "/imgpaises/img Inglaterra/Restaurantes/The Waterside Inn - Bray, Berkshire.png", "Almoço de Segunda a sexta, das 12h30 às 14h, Jantar de Segunda a sábado, das 19h às 21h30 e Fechado de Domingos e feriados ", -51.50947410902787, "Waterside Inn, Ferry Road, Bray, Berkshire SL6 2AT, Reino Unido ", -0.69988253637339048, "The Waterside Inn - Bray, Berkshire", 4, "+44 1628 620 691" },
                    { 138, "O Ledbury é um restaurante com duas estrelas Michelin em Notting Hill, Londres, Inglaterra. É conhecido por sua culinária moderna europeia com foco em ingredientes sazonais e de alta qualidade. O restaurante é comandado pelo chef Brett Graham, que assumiu o comando em 2011. Graham manteve a tradição de excelência do restaurante, e o Ledbury continua a ser um dos restaurantes mais aclamados de Londres. ", "/imgpaises/img Inglaterra/Restaurantes/The Ledbury - Londres.png", "Fechado de Terça-feira e Quarta-feira, Almoço de Quinta a Segunda, das 12h30 às 14h e Jantar de Quinta a Segunda, das 19h às 21h30", -51.517135248488763, "127 Ledbury Road, Notting Hill, Londres W11 2AQ, Reino Unido ", -0.20014887500168768, "The Ledbury - Londres", 4, "+44 20 7792 9090 " },
                    { 139, "O Museu Britânico é um dos maiores e mais importantes museus do mundo. Ele abriga uma vasta coleção de artefatos da história e da cultura humana, desde a pré-história até o presente. O museu foi fundado em 1753 e está situado em Bloomsbury, Londres. O edifício principal do museu é uma estrutura imponente em estilo neoclássico. ", "/imgpaises/img Inglaterra/Cultura/Museu Britânico - Londres.png", "Aberto diariamente das 10h às 17h30, Fechado das 24, 25 e 26 de dezembro e 1º de janeiro ", -51.520053741705155, "Great Russell Street, Londres WC1B 3DG, Reino Unido ", -0.12687081363462369, "Museu Britânico - Londres", 4, "+44 20 7323 8299 " },
                    { 140, "O Palácio de Buckingham é a residência oficial do monarca do Reino Unido em Londres. É um dos maiores e mais luxuosos palácios do mundo. O palácio foi construído em 1703 e foi originalmente a casa do Duque de Buckingham. Em 1762, o rei George III o adquiriu para a Coroa Britânica. ", "/imgpaises/img Inglaterra/Cultura/Palacio de Buckingham - Londres.png", "Aberto todos os dias 24h", -51.501817695437175, "Buckingham Palace, London SW1A 1AA, Reino Unido", -0.14163255228754965, "Palacio de Buckingham - Londres", 4, "+44 20 7323 1234" },
                    { 141, "O Castelo de Windsor é a maior e mais antiga fortaleza habitada do mundo. É a residência oficial da Rainha Elizabeth II no Reino Unido. O castelo foi fundado por Guilherme, o Conquistador, no século XI. Ao longo dos séculos, o castelo foi ampliado e reformado por vários monarcas ingleses. ", "/imgpaises/img Inglaterra/Cultura/Castelo de Windsor - Windsor.png", "Aberto ao público em 22 de julho a 2 de outubro de 2023, de Segunda a sábado das 10h às 17h15 (última entrada às 16h15) e de Domingo das 12h15 às 17h15 (última entrada às 16h15) ", -51.484775461096895, "Windsor Castle, Windsor SL4 1NJ, Reino Unido ", -0.60470315173861966, "Castelo de Windsor - Windsor", 4, "+44 300 123 7300" },
                    { 142, "Os Banhos Romanos são um complexo de ruínas romanas bem preservadas em Bath, Inglaterra. Eles foram construídos no século I d.C. e eram um importante centro social e religioso para os romanos. Os banhos são compostos por uma série de piscinas, salas de vapor e saunas. As piscinas eram aquecidas por um sistema de hipocausto, que usava o calor do fogo subterrâneo.", "/imgpaises/img Inglaterra/Cultura/Banhos Romanos - Bath.png", "Aberto diariamente das 9h às 17h (última entrada às 16h) e Fechado em 24, 25 e 26 de dezembro ", -51.382137297061554, "Roman Baths, Stall Street, Bath BA1 1LZ, Reino Unido ", -2.3654564933353921, "Banhos Romanos - Bath", 4, "+44 1225 477 777 " },
                    { 143, "O Museu Mundial de Liverpool é um dos maiores museus nacionais do Reino Unido. Ele abriga uma vasta coleção de artefatos da história e da cultura humana, desde a pré-história até o presente. O museu foi fundado em 1851 e está situado no centro de Liverpool. O edifício principal do museu é uma estrutura imponente em estilo neoclássico. ", "/imgpaises/img Inglaterra/Cultura/Museu da Liverpool World Museum - Liverpool.png", "Aberto diariamente das 10h às 17h e Fechado em 24, 25 e 26 de dezembro ", -53.406785826577334, "World Museum, William Brown Street, Liverpool L3 8EN, Reino Unido ", -2.9876937727547936, "Museu da Liverpool World Museum - Liverpool", 4, "+44 151 478 4393 " },
                    { 144, "O Museu de História de Manchester é um museu que narra a história da cidade e da região, desde a pré-história até os dias atuais. Ele abriga uma vasta coleção de artefatos, incluindo roupas, ferramentas, armas, documentos e fotografias. ", "/imgpaises/img Inglaterra/Cultura/Museu de História de Manchester - Manchester.png", "De Terça a sábado das 10h às 17h, Domingo das 12h às 17h e Fechado em 24, 25 e 26 de dezembro ", -53.466876910568303, "55 Mosley Street, Manchester M2 3JL, Reino Unido ", -2.2344236037865302, "Museu de História de Manchester - Manchester", 4, "+44 161 838 9120 " },
                    { 145, "O Parque Nacional Gran Paradiso é o parque nacional mais antigo da Itália, fundado em 1922. Localiza-se no Vale de Aosta e no Piemonte, em torno do maciço do Gran Paradiso. O parque abriga uma grande variedade de flora e fauna, incluindo o íbex, o camurça, a marmota e a águia real.", "/imgpaises/img Itália/Natureza/Parco Nazionale Gran Paradiso - Alpes.png", "Todos os dias 24h", -45.522177910837051, "Parco Nazionale Gran Paradiso Cogne, 11012 AO", -7.3245374411027502, "Parco Nazionale Gran Paradiso (Alpes)", 5, "+39 0165 740 011" },
                    { 146, "Os Jardins Villa Borghese são um dos maiores parques públicos de Roma, com uma área de 800.000 metros quadrados. O parque foi criado no século XVII pelo cardeal Scipione Borghese e posteriormente doado à cidade de Roma em 1903.", "/imgpaises/img Itália/Natureza/Villa Borghese Gardens - Roma.png", "Todos os dias 24h", -41.914061799773677, "Piazzale Napoleone I, 00197 Roma RM", -12.485338881394522, "Villa Borghese Gardens (Roma)", 5, "+39 06 32 810" },
                    { 147, "O Parque Nacional Cinque Terre é um parque nacional italiano que se estende ao longo da costa da Ligúria, entre as cidades de La Spezia e Levanto. O parque é composto por cinco vilas: Riomaggiore, Manarola, Corniglia, Vernazza e Monterosso al Mare. As Cinque Terre são famosas por suas casas coloridas, que se agarram às encostas íngremes dos penhascos.", "/imgpaises/img Itália/Natureza/Parco Nazionale delle Cinque Terre - Ligúria.png", "De segunda a sexta-feira, das 9h às 13h e das 14h às 17h", -44.128224485905022, "Parco Nazionale delle Cinque Terre Via Aldo Romano, 16 19018 La Spezia SP", -9.7124443410322705, "Parco Nazionale delle Cinque Terre (Ligúria)", 5, "+39 0187 730 274" },
                    { 148, "O Zoológico Safari Fasano é um zoológico e parque de diversões localizado em Fasano, na região de Puglia, na Itália. O zoológico abriga mais de 2.000 animais de 200 espécies diferentes, incluindo leões, tigres, elefantes, girafas e zebras. O parque de diversões tem várias atrações, como montanhas-russas, carrosséis e um parque aquático.", "/imgpaises/img Itália/Natureza/Zoo Safari Fasano - Puglia.png", "Aberto todos os dias das 9h até as 18h", -40.832605507573959, "Strada Provinciale per Fasano, 72, 72015 Fasano BR", -17.340702823670295, "Zoo Safari Fasano (Puglia)", 5, "+39 080 441 4777" },
                    { 149, "O Parco Nazionale d'Abruzzo, Lazio e Molise é um parque nacional italiano que se estende pelas regiões de Abruzzo, Lazio e Molise. O parque foi criado em 1922 e é um dos mais antigos parques nacionais da Itália. O parque abriga uma grande variedade de flora e fauna, incluindo lobos, ursos marrons, linces e águias reais.", "/imgpaises/img Itália/Natureza/Parco Nazionale d'Abruzzo, Lazio e Molise.png", "Segunda a sexta, das 9h às 13h e das 14h às 17h", -41.809014792666332, "Parco Nazionale d'Abruzzo, Lazio e Molise Viale A. Gramsci, 300 67032 Pescasseroli AQ", -13.790006594879545, "Parco Nazionale d'Abruzzo (Lazio e Molise)", 5, "+39 0862 879 111" },
                    { 150, "O Parco del Valentino é um parque público de 42 hectares situado na margem esquerda do Rio Pó, em Turim, Itália. O parque foi criado em 1856 e é um dos maiores parques urbanos da Europa.", "/imgpaises/img Itália/Natureza/Parco del Valentino - Turim.png", "Todos os dias 24h", -45.054968137617259, "Corso Massimo d'Azeglio, Turim", -7.6866073508560167, "Parco del Valentino (Turim)", 5, "+39 011 011 2550" },
                    { 151, "A Galleria Vittorio Emanuele II é um centro comercial de luxo em Milão, Itália. Foi projetada por Giuseppe Mengoni e inaugurada em 1867. A galeria é considerada um dos marcos mais importantes de Milão e um dos mais belos centros comerciais do mundo.", "/imgpaises/img Itália/Compras/Galleria Vittorio Emanuele II - Milão.png", "Todos os dias 24h", -45.465832982070765, "Piazza del Duomo, 2, 20121 Milano MI", -9.1900621545899526, "Galleria Vittorio Emanuele II (Milão)", 5, "+39 02 869 021" },
                    { 152, "A Via del Corso é uma das principais ruas comerciais de Roma, Itália. Ela se estende desde a Piazza del Popolo até a Piazza Venezia e é ladeada por lojas de todos os tipos, desde lojas de grife internacionais até lojas de souvenirs. A rua também é conhecida por seus cafés e restaurantes.", "/imgpaises/img Itália/Compras/Via del Corso - Roma.png", "Todos os dias 24h", -42.040333792760379, "Via del Corso, 00187 Roma RM", -12.437366684452311, "Via del Corso (Roma)", 5, "+39 06 6710 9444" },
                    { 153, "O Designer Outlet Valdichiana Village é um outlet de grife localizado em Foiano della Chiana, na Toscana, Itália. O outlet abriga mais de 140 lojas de marcas famosas, como Gucci, Prada e Versace, com descontos de até 70%. O outlet também oferece uma variedade de restaurantes e cafés, um playground e um serviço de Wi-Fi gratuito.", "/imgpaises/img Itália/Compras/Designer Outlet Valdichiana Village - Arezzo.png", "De Segunda a domingo das 10h às 20h Fechado na Páscoa e Aberto de Segunda de Páscoa das10h às 20h", -43.225472143447668, "Via S. Margherita, 5, 52041 Foiano della Chiana AR", -11.801671323784579, "Designer Outlet Valdichiana Village (Arezzo)", 5, "+39 0575 401 200" },
                    { 154, "La Rinascente é uma loja de departamentos de luxo localizada na Piazza della Repubblica, em Florença, Itália. A loja foi fundada em 1865 e é uma das lojas de departamentos mais antigas da Itália. La Rinascente oferece uma ampla variedade de produtos, incluindo roupas, acessórios, cosméticos, artigos para casa e eletrônicos. A loja também possui um restaurante e um café.", "/imgpaises/img Itália/Compras/La Rinascente - Florença.png", "De Segunda a sábado das 9h30 às 20h, Domingo das 10h às 20h e Fechado em 25 de dezembro e 1º de janeiro", -43.771456681396316, "Piazza della Repubblica, 2, 50123 Firenze FI", -11.254698198687759, "La Rinascente (Florença)", 5, "+39 055 276 81" },
                    { 155, "O The Mall é um outlet de luxo localizado em Leccio, na Toscana, Itália. O outlet abriga mais de 80 lojas de marcas famosas, como Gucci, Prada e Versace, com descontos de até 70%. O outlet também oferece uma variedade de restaurantes e cafés, um playground e um serviço de Wi-Fi gratuito.", "/imgpaises/img Itália/Compras/The Mall- Leccio.png", "De Segunda a sábado das 10h às 19h, Domingo das 10h às 19h e Fechado em 25 de dezembro e 1º de janeiro", -43.702302839396189, "Via Europa, 8, 50065 Leccio FI", -11.464037914196865, "The Mall (Leccio)", 5, "+39 055 865 7775" },
                    { 156, "O Centro Commerciale Porta di Roma é um shopping center localizado em Roma, Itália. É o maior shopping center da Europa, com mais de 220 lojas, incluindo lojas de grife, lojas de departamento, restaurantes e cafés. O shopping center também possui um cinema, um parque de diversões e um parque aquático.", "/imgpaises/img Itália/Compras/Centro Commerciale Porta di Roma - Roma.png", "De Segunda a sábado das 9h às 21h, Domingo das 9h às 20h e Fechado em 25 de dezembro e 1º de janeiro", -41.971843786693199, "Via del Ponte di Piscina Cupa, 64, 00154 Roma RM", -12.540170294887336, "Centro Commerciale Porta di Roma (Roma)", 5, "+39 06 551 7292" },
                    { 157, "O Centro Commerciale Porta di Roma é um shopping center localizado em Roma, Itália. É o maior shopping center da Europa, com mais de 220 lojas, incluindo lojas de grife, lojas de departamento, restaurantes e cafés. O shopping center também possui um cinema, um parque de diversões e um parque aquático.", "/imgpaises/img Itália/VidaNoturna/Armani Privé - Milão.png", "De Segunda a sábado das 9h às 21h, Domingo das 9h às 20h e Fechado em 25 de dezembro e 1º de janeiro", -45.466070812477703, "Via del Ponte di Piscina Cupa, 64, 00154 Roma RM", -9.189994978333953, "Armani Privé (Milão)", 5, "+39 06 551 7292" },
                    { 158, "O Campo de' Fiori é uma praça histórica localizada no centro de Roma, Itália. A praça é conhecida por seu mercado de flores, que funciona de segunda a sábado, das 7h às 13h. A praça também é conhecida por seus bares e restaurantes, que oferecem uma variedade de comidas e bebidas.", "/imgpaises/img Itália/VidaNoturna/Campo de' Fiori (área com vários bares) - Roma.png", "Todos os dias 24h", -45.465742688090081, "Piazza Campo de' Fiori, 00186 Roma RM, Itália", -9.1899977811266353, "Campo de' Fiori (área com vários bares) (Roma)", 5, "+39 06 6710 9444" },
                    { 159, "Yab Discoteca é uma boate moderna e elegante localizada no centro de Florença, Itália. A boate oferece uma variedade de música, desde música pop até música eletrônica. Yab Discoteca também oferece uma variedade de bebidas e comidas.", "/imgpaises/img Itália/VidaNoturna/Yab Discoteca - Florença.png", "Sexta-feira das 23h às 4h e Sábado das 23h às 4h", -43.771051161641012, "TVia de' Pecori, 32r, 50123 Firenze FI, Itália", -11.252713911719718, "Yab Discoteca (Florença)", 5, "+39 392 494 9852" },
                    { 160, "O Bobino Club é um clube noturno histórico localizado no centro de Milão, Itália. O clube foi fundado em 1958 e é conhecido por sua música ao vivo, DJs e eventos especiais. O Bobino Club oferece uma variedade de gêneros musicais, incluindo jazz, blues, rock e música eletrônica.", "/imgpaises/img Itália/VidaNoturna/Bobino Milano- Milão.png", "De Sexta-feira das 23h às 4h e Sábado das 23h às 4h", -45.453737763062662, "Corso Vittorio Emanuele II, 22, 20122 Milano MI, Itália", -9.1698645406426795, "Bobino Milano (Milão)", 5, "+39 345 254 9379" },
                    { 161, "Shari Vari Playhouse é um teatro de marionetes único e mágico localizado em Veneza, Itália. O teatro apresenta uma variedade de shows de marionetes para crianças e adultos, utilizando técnicas tradicionais e inovadoras. As apresentações são em italiano e inglês.", "/imgpaises/img Itália/VidaNoturna/Shari Vari Playhouse - Veneza.png", "De Terça a sábado das 10h às 18h e de Domingo e segunda é Fechado", -41.897598759927291, "Calle Lunga San Barnaba, 2772/A, 30123 Venezia VE, Itália", -12.476110636768039, "Shari Vari Playhouse (Veneza)", 5, "+39 340 938 8410" },
                    { 162, "O Phi Beach Club, em Baja Sardinia, é um oásis de pura elegância e sofisticação. Localizado na Costa Esmeralda da Sardenha, banhado por águas cristalinas e rodeado por uma natureza exuberante, o Phi Beach Club oferece aos seus visitantes uma experiência única e inesquecível.", "/imgpaises/img Itália/VidaNoturna/Phi Beach Club - Baia Sardinia.png", "Aberto todos os dias das 10h às 20h e Junho a setembro Aberto todos os dias das 10h às 2h", -41.142477040371382, "Località Phi Beach, 07020 Baja Sardinia SS, Itália", -9.4668848385774496, "Phi Beach Club (Baia Sardinia)", 5, "+39 342 838 4410" },
                    { 163, "A Basílica de São Pedro é uma das maiores igrejas do mundo e um dos locais religiosos mais importantes do cristianismo. Ela está localizada na Cidade do Vaticano, a menor nação do mundo, e é a sede do Papa.", "/imgpaises/img Itália/Fe/Basílica de São Pedro - Vaticano (Roma).png", "De 1º de abril a 30 de setembro é Aberto das 7h às 19h De 1º de outubro a 31 de março é  Aberto das 7h às 18h30 das 8h às 17h", -41.90312309115027, "Piazza San Pietro, 00120 Città del Vaticano, Itália", -12.453764763905507, "Basílica de São Pedro - Vaticano (Roma)", 5, "+39 06 6988 3111" },
                    { 164, "A Basílica de São Marcos é um dos edifícios mais emblemáticos de Veneza, Itália. É uma catedral em estilo bizantino que foi construída entre os séculos IX e XI. A basílica é dedicada a São Marcos, o santo padroeiro de Veneza.", "/imgpaises/img Itália/Fe/Basílica de São Marcos - Veneza.png", "De Segunda a sábado das 9h30 às 17h e de Domingos e feriados das 14h às 16h30 (de 16 de abril a 28 de outubro, até 17h)", -42.064305668267899, "Piazza San Marco, 328, 30124 Venezia VE, Itália", -12.472640691886971, "Basílica de São Marcos (Veneza)", 5, "+39 041 271 5902" },
                    { 165, "A Catedral de Milão, também conhecida como Duomo di Milano, é uma das maiores catedrais do mundo e um dos principais pontos turísticos da Itália. A catedral é dedicada à Natividade de Maria. A construção da catedral começou em 1386 e durou mais de seis séculos. A catedral é um exemplo impressionante da arquitetura gótica, com suas torres altas, suas esculturas detalhadas e seus vitrais coloridos.", "/imgpaises/img Itália/Fe/Duomo di Milano (Catedral de Milão) - Milão.png", "De Segunda a sábado das 9h às 19h (última entrada às 18h10) e de Domingos e feriados das 9h às 17h (última entrada às 16h10)", -45.465841460016463, "Piazza del Duomo, 20122 Milano MI, Itália", -9.1924412251988947, "Duomo di Milano (Catedral de Milão) (Milão)", 5, "+39 02 7202 3375" },
                    { 166, "A Basílica de São Francisco de Assis é um dos locais religiosos mais importantes da Itália. É um complexo religioso que inclui duas basílicas, uma cripta e um museu. A basílica foi construída no século XIII para abrigar o túmulo de São Francisco de Assis, fundador da Ordem Franciscana.", "/imgpaises/img Itália/Fe/Basílica de São Francisco de Assis - Assis.png", "Aberto todos os dias das 6h até as 18h", -43.525663732419396, "Piazza San Francesco, 2, 06081 Assisi PG, Itália", -11.89605563853403, "Basílica de São Francisco de Assis (Assis)", 5, "+39 075 812 041" },
                    { 167, "A Catedral de Santa Maria del Fiore, também conhecida como Duomo de Florença, é uma das maiores catedrais do mundo e um dos principais pontos turísticos da Itália. A catedral é dedicada à Nossa Senhora das Flores. A construção da catedral começou em 1296 e durou mais de 150 anos. A catedral é um exemplo impressionante da arquitetura gótica, com sua cúpula imponente, seus campanários altos e suas esculturas detalhadas.", "/imgpaises/img Itália/Fe/Basílica de São Marcos - Veneza.png", "De Segunda a sábado das 10h às 17h (última entrada às 16h30) e de Domingos e feriados das 13h30 às 16h30 (última entrada às 16h)", -43.774072798155508, "Piazza del Duomo, 50122 Firenze FI, Itália", -11.255444949372688, "Catedral de Santa Maria del Fiore (Florença)", 5, "+39 055 230 2880" },
                    { 168, "A Catedral de Palermo, também conhecida como Duomo di Palermo, é uma catedral em estilo normando localizada em Palermo, Sicília, Itália. A catedral é dedicada à Assunção da Virgem Maria. A construção da catedral começou em 1185 e durou mais de 200 anos. A catedral é um exemplo impressionante da arquitetura normanda, com sua fachada ricamente decorada, seus mosaicos dourados e seus claustros.", "/imgpaises/img Itália/Fe/Catedral de Palermo - Palermo.png", "De Segunda a sábado das 7h30 às 19h30 Domingos e feriados das 8h às 13h e depois das 16h às 19h30", -38.114735480095867, "Via Vittorio Emanuele, 90, 90134 Palermo PA, Itália", -13.355878448220029, "Catedral de Palermo (Palermo)", 5, "+39 091 334 377" },
                    { 169, "Osteria Francescana é um restaurante com três estrelas Michelin em Modena, Itália. É propriedade e operado pelo chef Massimo Bottura. O restaurante é considerado um dos melhores do mundo e foi nomeado o melhor restaurante do mundo em 2016 e 2018 pelo The World's 50 Best Restaurants.", "/imgpaises/img Itália/Restaurantes/Osteria Francescana - Modena.png", "De Quarta a sábado das 12h às 14h30 e depois das 19h30 às 22h e de Fechado domingo, segunda e terça-feira", -44.645740539118442, "Via Stella, 22, 41121 Modena MO, Itália", -10.921229314649926, "Osteria Francescana (Modena)", 5, "+39 059 223 903" },
                    { 170, "Trattoria da Romano é um restaurante tradicional veneziano em Veneza, Itália. É um restaurante familiar que serve pratos venezianos autênticos há mais de 50 anos. O restaurante está localizado em um beco tranquilo no centro histórico de Veneza. O interior é acolhedor e rústico, com paredes de tijolos expostos e mesas de madeira.", "/imgpaises/img Itália/Restaurantes/Trattoria da Romano - Veneza.png", "De Terça a sábado das 12h às 14h30 e depois das 19h às 22h e é Fechado de domingo e segunda-feira", -45.486183996234601, "Calle del Forno, 2292/A, 30122 Venezia VE, Itália", -12.418251571887863, "Trattoria da Romano (Veneza)", 5, "+39 041 522 2277" },
                    { 171, "Dal Pescatore é um restaurante com três estrelas Michelin em Canneto sull'Oglio, Itália. É propriedade e operado pelos chefs Nadia Santini, Giovanni Santini e Bruna Santini. O restaurante é considerado um dos melhores da Itália e foi nomeado o 48º melhor restaurante do mundo em 2009 pelo The World's 50 Best Restaurants.", "/imgpaises/img Itália/Restaurantes/Dal Pescatore - Canneto sull'Oglio.png", "De Quarta a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30 e de Domingo das 12h30 às 14h30 e Fechado de segunda e terça-feira", -45.172274935371362, "Via S. Antonio, 5, 25040 Canneto sull'Oglio MN, Itália", -10.357242478405302, "Dal Pescatore (Canneto sull'Oglio)", 5, "+39 0376 714 010" },
                    { 172, "A Enoteca Pinchiorri é um restaurante com três estrelas Michelin em Florença, Itália. É propriedade e operado pelos chefs Annie Féolde e Giorgio Pinchiorri. O restaurante é considerado um dos melhores do mundo e foi nomeado o 32º melhor restaurante do mundo em 2008 pela revista British Restaurant.", "/imgpaises/img Itália/Restaurantes/Enoteca Pinchiorri - Florença.png", "De Terça a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30 e Fechado de domingo e segunda-feira", -43.770741908828612, "Via Ghibellina, 87, 50122 Firenze FI, Itália", -11.261363626632706, "Enoteca Pinchiorri (Florença)", 5, "+39 055 200 7375" },
                    { 173, " La Pergola é um restaurante com três estrelas Michelin em Roma, Itália. É propriedade e operado pelo chef Heinz Beck. O restaurante é considerado um dos melhores do mundo e foi nomeado o 18º melhor restaurante do mundo em 2023 pela revista The World's 50 Best Restaurants.", "/imgpaises/img Itália/Restaurantes/La Pergola - Roma.png", "De Terça a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30 e Fechado de domingo e segunda-feira", -41.919890973555837, "Via Veneto, 150, 00187 Roma RM, Itália", -12.446059510570469, "La Pergola (Roma)", 5, "+39 06 488 7800" },
                    { 174, "Antica Corte Pallavicina é um restaurante com uma estrela Michelin em Polesine Parmense, Itália. É propriedade e operado pela família Spigaroli. O restaurante está situado em um antigo castelo do século XIV, às margens do rio Po.", "/imgpaises/img Itália/Restaurantes/Antica Corte Pallavicina - Polesine Parmense.png", "De Segunda a sábado das 12h30 às 14h30 e depois das 19h30 às 22h30, Domingo das 12h30 às 14h30 e Feriados das 12h30 às 14h30 (mediante reserva)", -45.022672354535167, "Strada Palazzo, 7, 43010 Polesine Parmense PR, Itália", -10.085748947040059, "Antica Corte Pallavicina (Polesine Parmense)", 5, "+39 0524 936 669" },
                    { 175, "Os Museus do Vaticano abrigam uma das maiores e mais importantes coleções de arte do mundo. Os museus estão localizados na Cidade do Vaticano, a menor cidade do mundo, e são a casa da Capela Sistina, que é considerada um dos mais importantes locais religiosos e artísticos do mundo.", "/imgpaises/img Itália/Cultura/Museu do Vaticano e Capela Sistina - Roma.png", "De Segunda a sábado das 9h às 20h (última entrada às 16h) e Fechado de domingo", -41.906839101819514, "Viale Vaticano, 00165 Città del Vaticano", -12.453579559497973, "Museu do Vaticano e Capela Sistina (Roma)", 5, "+39 06 6988 3332" },
                    { 176, "O Coliseu é um anfiteatro oval em Roma, Itália. É o maior anfiteatro do mundo e foi construído no século I d.C. pelo imperador Vespasiano. O Coliseu foi usado para combates de gladiadores, execuções e outros eventos públicos. O Coliseu é um Patrimônio Mundial da UNESCO e uma das atrações turísticas mais populares da Itália. O Coliseu está aberto ao público para visitas guiadas e autoguiadas.", "/imgpaises/img Itália/Cultura/Coliseu - Roma.png", "De Segunda a sábado das 9h às 16h30 (última entrada às 16h) e Fechado dia 25 de dezembro e 1º de janeiro", -41.906870810692197, "Piazza del Colosseo, 1, 00184 Roma RM, Itália", -12.45364393136315, "Coliseu (Roma)", 5, "+39 06 399 67 70" },
                    { 177, "A Galleria degli Uffizi é um museu de arte em Florença, Itália. É um dos museus mais importantes do mundo e abriga uma vasta coleção de pinturas e esculturas do Renascimento italiano.", "/imgpaises/img Itália/Cultura/Museu Uffizi - Florença.png", "De Terça a domingo das 8h15 às 18h50 (última entrada às 18h05) e Fechado de segunda-feira, 1º de janeiro, 1º de maio e 25 de dezembro", -43.769643198347396, "Piazzale degli Uffizi, 6, 50122 Firenze FI, Itália", -11.25539636411926, "Museu Uffizi (Florença)", 5, "+39 055 294883" },
                    { 178, "Pompeia é uma antiga cidade romana que foi enterrada por uma erupção do Vesúvio em 79 d.C. A cidade está localizada na Itália, perto de Nápoles. As ruínas de Pompéia são um Patrimônio Mundial da UNESCO e um destino turístico popular.", "/imgpaises/img Itália/Cultura/Pompeia.png", "Aberto todos os dias das 9h às 17h (última entrada às 16h) e Fechado em 25 de dezembro e 1º de janeiro", -40.75097322205805, "Pompéia, Itália", -14.501137636010677, "Pompeia (Pompeia)", 5, "+39 081 857 5347" },
                    { 179, "O Palazzo Ducale (Palácio Ducal) é um dos edifícios mais emblemáticos de Veneza, Itália. Foi a sede do governo da República de Veneza durante séculos e é um dos maiores e mais impressionantes palácios góticos do mundo.", "/imgpaises/img Itália/Cultura/Palazzo Ducale (Palácio Ducal) - Veneza.png", "Aberto todos os dias das 8h30 às 19h (última entrada às 18h) e Fechado em 25 de dezembro e 1º de janeiro", -45.434063029429126, "Piazza San Marco, 1, 30124 Venezia VE, Itália", -12.339959987562988, "Palazzo Ducale (Palácio Ducal) (Veneza)", 5, "+39 041 271 5934" },
                    { 180, "A Piazza del Campo é a principal praça de Siena, Itália. É uma das praças mais famosas da Itália e é conhecida por sua forma de concha e por sua beleza arquitetônica. A praça é o lar de vários edifícios históricos, incluindo o Palazzo Pubblico, a Torre del Mangia e a Fonte Gaia.", "/imgpaises/img Itália/Cultura/Piazza del Campo e Palazzo Pubblico - Siena.png", "Aberto todos os dias 24h", -43.31825623772815, "Piazza del Campo, 53100 Siena SI, Itália", -11.331932240398123, "Piazza del Campo e Palazzo Pubblico (Siena)", 5, "+39 0577 292 222" },
                    { 181, "O Jardim Zoológico de Lisboa, fundado em 1884, é um dos mais antigos da Europa. Abriga cerca de 2000 animais de 300 espécies diferentes, em habitats recriados para simular seus ambientes naturais. O zoológico também desenvolve programas de conservação e investigação científica.", "/imgpaises/img Portugal/Natureza/Zoológico de Lisboa (Lisboa).png", "De Novembro a fevereiro das 10h às 18h (última entrada às 17h) e de Março a outubro das 10h às 19h (última entrada às 18h)", -38.743250364769374, "Estrada de Benfica 72, 1500-474 Lisboa", -9.1691502592214729, "Zoológico de Lisboa (Lisboa)", 6, "+351 217780200" },
                    { 182, "O Zoomarine Algarve é um parque temático que combina diversão com educação ambiental. Abriga uma grande variedade de animais, incluindo golfinhos, focas, leões marinhos, aves de rapina e tubarões. O parque oferece shows com animais, apresentações educativas, atrações aquáticas e muito mais. ", "/imgpaises/img Portugal/Natureza/Zoomarine Algarve (Albufeira).png", "Não abre de segunda e terça e nos outros dias abre das 10h até as 17h.", -37.127254461638081, "Estrada Nacional 125, Guia, 8200-864 Albufeira", -8.3143912263061868, "Zoomarine Algarve (Albufeira)", 6, "+351 289560300" },
                    { 183, "A Mata Nacional do Buçaco é uma floresta nacional localizada na Serra do Buçaco, no município da Mealhada, em Portugal. A mata foi originalmente plantada por monges carmelitas no século XVII e é agora um Monumento Nacional. A Mata Nacional do Buçaco é conhecida por sua beleza natural, com uma variedade de árvores e plantas, incluindo o famoso cedro-do-Buçaco. A mata também abriga uma variedade de animais selvagens, como veados, javalis e raposas.", "/imgpaises/img Portugal/Natureza/Mata Nacional do Bussaco (Luso).png", "Aberto todos os dias 24h.", -40.377267388811504, "Mata Nacional do Buçaco, 3540-504 Luso", -8.3669189475141206, "Mata Nacional do Bussaco (Luso)", 6, "+351 231540100" },
                    { 184, "O Parque Biológico de Gaia é um centro de educação ambiental que promove a compreensão da natureza e da importância da sua preservação. O parque possui uma área de 35 hectares, onde se podem encontrar diversos habitats naturais, como bosques, carvalhais, pinhais, lagos e ribeiros. O parque também abriga uma grande variedade de animais selvagens, como aves, répteis e mamíferos.", "/imgpaises/img Portugal/Natureza/Parque Biológico de Gaia (Vila Nova de Gaia).png", "De Terça a sexta das 9h às 18h, Sábado e domingo das 10h às 19h e Fechado de Segundas-feiras, 1º de janeiro, 1º de maio e 25 de dezembro", -41.097529045150402, "Lugar da Lavandeira, 4400-448 Avintes, Vila Nova de Gaia", -8.5542171591142839, "Parque Biológico de Gaia (Vila Nova de Gaia)", 6, "+351 223743737" },
                    { 185, "O Oceanário de Lisboa é um dos maiores aquários da Europa. Abriga mais de 8.000 animais marinhos de 500 espécies diferentes, de todos os oceanos do mundo. O Oceanário está dividido em quatro habitats: Atlântico Norte, Pacífico, Índico e Antártida. Os visitantes podem observar os animais através de grandes painéis de vidro, aprender sobre a importância da preservação dos oceanos e participar em diversas atividades educativas.", "/imgpaises/img Portugal/Natureza/Lisboa Oceanarium (Lisboa).png", "Todos os dias das 10h às 20h (última entrada às 19h), 25 de dezembro das 13h às 18h e 1º de janeiro das 12h às 18h", -38.763752613076882, "Esplanada D. Carlos I, 1990-005 Lisboa", -9.0936985880572614, "Lisboa Oceanarium (Lisboa)", 6, "+351 218917000" },
                    { 186, "O Parque Natural do Alvão é uma área protegida localizada na região do Alto Douro, em Portugal. O parque foi criado em 1983 e abrange uma área de cerca de 72 km². O parque é conhecido por sua beleza natural, com paisagens montanhosas, florestas densas e rios cristalinos. O parque também abriga uma grande variedade de animais selvagens, como lobos, veados e aves de rapina.", "/imgpaises/img Portugal/Natureza/Parque Natural do Alvão (região do Alto Douro).png", "Aberto todos os dias 24h.", -41.3656874920189, "Apartado 10, 5085-401 Vila Real", -7.8176957302650907, "Parque Natural do Alvão (região do Alto Douro)", 6, "+351 254675289" },
                    { 187, "O Centro Comercial Colombo é o maior centro comercial da Península Ibérica em número total de lojas. Abriga mais de 340 lojas, restaurantes e cafés, além de um cinema, um bowling e um parque infantil. O centro comercial está localizado em Benfica, próximo ao Estádio da Luz.", "/imgpaises/img Portugal/Compras/Centro Comercial Colombo (Lisboa).png", "De Segunda a sexta das 10h às 23h e de Sábado, domingo e feriados das 10h às 22h", -38.753736408250042, "Avenida Lusíada, 1500-454 Lisboa", -9.1884235899141746, "Centro Comercial Colombo (Lisboa)", 6, "+351 217160300" },
                    { 188, "O Algarve Shopping é um centro comercial moderno e espaçoso, com mais de 120 lojas, restaurantes e cafés. O centro comercial oferece uma grande variedade de opções de compras, desde lojas de roupas e acessórios até lojas de eletrônicos e artigos para o lar. O Algarve Shopping também possui um cinema, um bowling e um parque infantil, o que o torna um ótimo lugar para se divertir com a família ou amigos.", "/imgpaises/img Portugal/Compras/Algarve Shopping (Albufeira).png", "De Segunda a sábado das 10h às 23h e de Domingo e feriados das10h às 22h", -37.127768674366706, "EN125, Guia, 8200-577 Albufeira", -8.2802308476580091, "Algarve Shopping (Albufeira)", 6, "+351 289589400" },
                    { 189, "O Forum Algarve é um centro comercial moderno e espaçoso, com mais de 100 lojas, restaurantes e cafés. O centro comercial oferece uma grande variedade de opções de compras, desde lojas de roupas e acessórios até lojas de eletrônicos e artigos para o lar. O Forum Algarve também possui um cinema, um bowling e um parque infantil, o que o torna um ótimo lugar para se divertir com a família ou amigos.", "/imgpaises/img Portugal/Compras/Forum Algarve (Faro).png", "De Segunda a sábado das 10h às 23h e de Domingo e feriados das10h às 22h", -37.028931349815529, "Estrada Nacional 125, Km 103, 8005-405 Faro", -7.9450941881324679, "Forum Algarve (Faro)", 6, "+351 289889300" },
                    { 190, "O Aqua Portimão é um centro comercial moderno e espaçoso, com mais de 100 lojas, restaurantes e cafés. O centro comercial oferece uma grande variedade de opções de compras, desde lojas de roupas e acessórios até lojas de eletrônicos e artigos para o lar. O Aqua Portimão também possui um cinema, um bowling e um parque infantil, o que o torna um ótimo lugar para se divertir com a família ou amigos.", "/imgpaises/img Portugal/Compras/Aqua Portimao (Portimão).png", "De Segunda a sexta das 10h às 23h e Sábado, domingo e feriados das 10h às 22h", -37.147922603471706, "Avenida Dr. Francisco Sá Carneiro, Loja 105, 8500-457 Portimão", -8.5436178899838762, "Aqua Portimao (Portimão)", 6, "+351 282420740" },
                    { 191, "O El Corte Inglés de Lisboa é um gigante comercial vibrante, pronto para atender a todos os seus desejos. Explore os diversos departamentos, desde a moda e beleza até a tecnologia e lazer, e encontre tudo o que precisa e muito mais. Saboreie uma deliciosa refeição no restaurante ou relaxe com um café e um lanche na cafeteria. A loja também oferece uma gama de serviços convenientes, como salão de beleza, lavanderia e estacionamento gratuito.", "/imgpaises/img Portugal/Compras/El Corte Inglés (Lisboa).png", "De Segunda a sábado das 10h às 23h e de Domingo e feriados das 10h às 22h", -38.73338957143639, "Avenida António Augusto Aguiar, 33, 1049-001 Lisboa", -9.1537568457318628, "El Corte Inglés (Lisboa)", 6, "+351 213538300" },
                    { 192, "Situado em Alcochete, a apenas 30 minutos de Lisboa e com passagem por uma das mais belas pontes da Europa, a ponte Vasco da Gama, o Freeport Lisboa Fashion Outlet é o local perfeito para um dia em cheio. Com mais de 150 marcas com descontos até 70% durante todo o ano, é o destino de shopping ideal para quem procura grandes marcas nacionais e internacionais. Aqui pode encontrar vestuário para homem, senhora e criança, acessórios de moda, perfumarias e uma excelência de serviços que contribuirão para tornar a sua experiência inesquecível. No Freeport Lisboa Fashion Outlet, a tradição e a modernidade dão origem a um lugar especial. A arquitetura eclética onde o traçado contemporâneo está em harmonia com o tradicional, as áreas de repouso e lazer, os espaços relvados e as zonas de água dão origem a um espaço comercial com caraterísticas únicas.", "/imgpaises/img Portugal/Compras/Freeport Lisboa Fashion Outlet - Alcochete.jpg", "10:00 ás 22:00", -38.752079911052874, "Avenida Euro 2004, Alcochete 2890-154 Portugal", -8.9391831475875332, "Freeport Lisboa Fashion Outlet  Alcochete", 6, "+351 21 234 3501" },
                    { 193, "O Cocktail Garden é um bar elegante e relaxante, situado no coração de Carvoeiro. O bar oferece uma grande variedade de cocktails clássicos e contemporâneos, além de uma seleção de vinhos, cervejas e outras bebidas. O Cocktail Garden também oferece uma variedade de petiscos e snacks, perfeitos para acompanhar a sua bebida.", "/imgpaises/img Portugal/VidaNoturna/Fábrica Braço de Prata (Lisboa).png", "Aberto todos os dias 24h. ", -38.743891387455783, "Rua do Barranco, 4, 8400-510 Carvoeiro", -9.1012529322413283, "Fábrica Braço de Prata (Lisboa)", 6, "+351 282358456" },
                    { 194, "O Cinco Lounge está situado no coração da Avenida António Augusto Aguiar, em Lisboa, e oferece um ambiente elegante e relaxante para desfrutar de uma bebida ou uma refeição leve.", "/imgpaises/img Portugal/VidaNoturna/Cinco Lounge (Lisboa).png", "De Segunda a sábado das 10h às 23h e de Domingo e feriados das 10h às 22h", -38.714290443425199, "Avenida António Augusto Aguiar, 33, 1049-001 Lisboa", -9.1496721592228081, "Cinco Lounge (Lisboa)", 6, "+351 213538300" },
                    { 195, "O Cocktail Garden é um bar elegante e relaxante, situado no coração de Carvoeiro. O bar oferece uma grande variedade de cocktails clássicos e contemporâneos, além de uma seleção de vinhos, cervejas e outras bebidas. O Cocktail Garden também oferece uma variedade de petiscos e snacks, perfeitos para acompanhar a sua bebida.", "/imgpaises/img Portugal/VidaNoturna/Cocktail Garden  (Carvoeiro).png", "Aberto todos os dias das 12h até as 23h", -37.0982379061237, "Rua do Barranco, 4, 8400-510 Carvoeiro", -8.4738588458028143, "Cocktail Garden  (Carvoeiro)", 6, "+351 282358456" },
                    { 196, "O USAxe Club é uma discoteca vibrante e moderna, localizada no coração do Porto. O clube oferece uma experiência de festa única, com música de alta qualidade, DJs internacionais e uma pista de dança espaçosa.", "/imgpaises/img Portugal/VidaNoturna/USAxe Club (Porto).png", "De Sexta-feira das 23h às 6h e de Sábado das 23h às 6h", -38.703151145069377, "Rua do Dr. Barbosa de Castro, 40, 4000-252 Porto", -9.1791244475896718, "USAxe Club (Porto)", 6, "+351 226094594" },
                    { 197, "O Largo da Oliveira é uma praça histórica e monumental situada no centro histórico de Guimarães, Portugal. A praça é considerada o berço da nacionalidade portuguesa, pois foi neste local que D. Afonso Henriques, o primeiro rei de Portugal, proclamou a independência do país em 1143.", "/imgpaises/img Portugal/VidaNoturna/Largo da oliveira (Guimarães).png", "Aberto todos os dias 24h", -41.443162635943132, "Largo da Oliveira, 4800-415 Guimarães", -8.2928897051377781, "Largo da Oliveira (Guimarães)", 6, "+351 226094594" },
                    { 198, "O Sky Bar Lisboa by SEEN é um bar rooftop elegante e sofisticado, situado no topo do Tivoli Avenida Liberdade Hotel. O bar oferece uma vista panorâmica deslumbrante da cidade de Lisboa, cocktails criativos e uma atmosfera vibrante.", "/imgpaises/img Portugal/VidaNoturna/Sky Bar (Lisboa).png", "De Segunda a quinta das18h às 02h e de Sexta a domingo das 18h às 03h", -38.721992824184888, "Avenida da Liberdade, 185, 9º andar, 1049-001 Lisboa", -9.1476181766327826, "Sky Bar (Lisboa)", 6, "+351 213538300" },
                    { 199, "O Mosteiro da Batalha é um dos mais importantes monumentos religiosos e históricos de Portugal. O mosteiro foi mandado construir pelo rei D. João I em 1386, em cumprimento de uma promessa feita à Virgem Maria pela vitória na Batalha de Aljubarrota. O mosteiro é um exemplar da arquitetura gótica portuguesa, com elementos manuelinos e renascentistas.", "/imgpaises/img Portugal/Fe/Mosteiro da Batalha (Batalha).png", "De Outubro a abril das 9h às 18h (última entrada às 17h30), Maio a setembro das 9h às 19h (última entrada às 18h30) e Encerrado em 25 de dezembro e 1 de janeiro", -39.659348443140594, "Largo da Batalha, 2440-406 Batalha", -8.8254862591805026, "Mosteiro da Batalha (Batalha)", 6, "+351 244766200" },
                    { 200, "O Mosteiro de Alcobaça é um dos mais importantes monumentos religiosos e históricos de Portugal. O mosteiro foi fundado em 1153 por D. Afonso Henriques, o primeiro rei de Portugal, e D. Bernardo de Claraval, fundador da Ordem de Cister. O mosteiro é um exemplar da arquitetura gótica portuguesa, com elementos manuelinos e renascentistas.", "/imgpaises/img Portugal/Fe/Mosteiro de Alcobaça (Alcobaça).png", "De Outubro a abril das 9h às 18h (última entrada às 17h30), Maio a setembro das 9h às 19h (última entrada às 18h30) e Encerrado em 25 de dezembro e 1 de janeiro", -39.548407620637661, "Largo Dom Afonso Henriques, 2400-001 Alcobaça", -8.9795530591855641, "Mosteiro de Alcobaça (Alcobaça)", 6, "+351 262590274" },
                    { 201, "A Sé do Porto, também conhecida como Catedral do Porto, é um dos principais monumentos da cidade do Porto e um dos mais importantes monumentos religiosos de Portugal. A sua construção iniciou-se no século XII e, ao longo dos séculos, sofreu diversas remodelações, o que resultou numa mistura de estilos arquitetónicos, com destaque para o românico, o gótico e o barroco.", "/imgpaises/img Portugal/Fe/Sé do Porto (Porto).png", "De Segunda a sexta das 9h às 19h, Sábado das 9h às 12h30 e depois das 14h às 19h e de Domingo das 14h às 19h", -41.143014662751, "Terreiro da Sé, 4050-573 Porto", -8.6110628591121774, "Sé do Porto (Porto)", 6, "+351 222002754" },
                    { 202, "A Basílica da Estrela, também conhecida como Real Basílica e Convento do Santíssimo Coração de Jesus, é um dos mais importantes monumentos religiosos de Lisboa. A sua construção iniciou-se no final do século XVIII em estilo barroco e neoclássico. ", "/imgpaises/img Portugal/Fe/Basílica da Estrela (Lisboa).png", "De Segunda a sexta das 9h às 13h e depois das 15h às 19h, Sábado das  9h às 13h e 14h às 18h e de Domingo das 14h às 18h ", -38.713540349205701, "Praça da Estrela, 1200-669 Lisboa ", -9.1608196880594832, "Basílica da Estrela (Lisboa)", 6, "+351 213962434" },
                    { 203, "A Catedral de Évora, também conhecida como Sé de Évora, é um dos mais importantes monumentos religiosos de Portugal e a maior catedral medieval do país. A sua construção iniciou-se no século XII em estilo românico, mas ao longo dos séculos sofreu diversas remodelações, o que resultou numa mistura de estilos arquitetónicos, com destaque também para o gótico e o barroco. ", "/imgpaises/img Portugal/Fe/Catedral de Évora (Évora).png", "De Segunda a sexta das 9h às 12h30 e depois das 14h às 18h, Sábado das 9h às 12h30 e de Domingo das 14h às 18h ", -38.57191515748675, "Largo Marquês de Marialva, 7000-586 Évora  ", -7.9068675322489517, "Catedral de Évora (Évora)", 6, "+351 266742422" },
                    { 204, "A Basílica da Santíssima Trindade é a mais recente construção do complexo do Santuário de Fátima. A sua construção iniciou-se em 2004 e foi concluída em 2007. A igreja é dedicada à Santíssima Trindade e tem capacidade para 8.633 pessoas sentadas. ", "/imgpaises/img Portugal/Fe/Basílica da Santíssima Trindade (Fátima).png", "Todos os dias das 08h até as 19h ", -39.629830534748123, "Santuário de Fátima, 2495-400 Fátima ", -8.6753589628947712, "Basílica da Santíssima Trindade (Fátima)", 6, "+351 249539600" },
                    { 205, "O Restaurante Delfina é um restaurante português tradicional localizado no coração de Lisboa. O restaurante é conhecido pela sua comida deliciosa, ambiente acolhedor e serviço atencioso.  ", "/imgpaises/img Portugal/Restaurantes/Delfina Restaurant.png", "De Terça a sexta das 12h30 às 15h30 e depois das 19h30 às 22h30, Sábado das 12h30 às 15h30 e depois das 19h30 às 23h00 e de Domingo e Segunda é Fechado  ", -38.708326353903175, "Rua Domingos Sequeira, 23, 1200-174 Lisboa ", -9.139260545732979, "Delfina Restaurant (Lisboa)", 6, "+351 213421735" },
                    { 206, "A Confeitaria Nacional é a confeitaria mais antiga de Lisboa, fundada em 1829. A confeitaria é conhecida pelos seus doces tradicionais portugueses, como os pastéis de nata, os travesseiros de Sintra e os bolos de arroz.  ", "/imgpaises/img Portugal/Restaurantes/Confeitaria Nacional (Lisboa).png", "De Segunda a sexta das 8h30 às 20h e de Sábado e domingo das 8h30 às 19h   ", -38.713361874433247, "Praça da Figueira 18B, 1100-241 Lisboa ", -9.1378723015495886, "Confeitaria Nacional (Lisboa)", 6, "+351 213424470" },
                    { 207, "O Restaurante O Melro é um restaurante português tradicional, com foco em pratos regionais do Ribatejo. O restaurante é conhecido pela sua comida deliciosa, ambiente familiar e serviço atencioso. ", "/imgpaises/img Portugal/Restaurantes/Restaurante o melro (Almeirim).png", "De Terça a sexta das 12h30 às 15h30 e depois das 19h30 às 22h30, Sábado das 12h30 às 15h30 e depois das 19h30 às 23h00 e de Domingo e Segunda é Fechado  ", -39.265678014314872, "Rua do Comércio, 12, 2080-047 Almeirim  ", -8.6963388475646433, "Restaurante o Melro (Almeirim)", 6, "+351 243592422" },
                    { 208, "O Café Progresso é um café histórico e tradicional em Ponta Delgada, Açores. O café foi fundado em 1875 e é conhecido pela sua decoração Art Déco, ambiente acolhedor e serviço atencioso.  ", "/imgpaises/img Portugal/Restaurantes/Café Progresso (Ponta Delgada).png", "De Segunda a sexta das 7h30 às 20h, Sábado das 8h às 19h e de Domingo é Fechado ", -39.437465393355012, "Avenida Infante Dom Henrique, 54, 9500-352 Ponta Delgada ", -8.3033293052301929, "Café Progresso (Ponta Delgada)", 6, "+351 296282340" },
                    { 209, "O Restaurante Ramila é um restaurante tradicional português, especializado em pratos regionais do Minho. O restaurante é conhecido pela sua comida deliciosa, ambiente familiar e serviço atencioso.   ", "/imgpaises/img Portugal/Restaurantes/Restaurante Ramila (Guimarães).png", "De Terça a sábado das 12h30 às 15h30 e depois das 19h30 às 22h30 e de Domingo e Segunda é Fechado ", -39.601020958990638, "Rua de Santa Maria, 34, 4800-437 Guimarães ", -8.6090533322559111, "Restaurante Ramila (Guimarães)", 6, "+351 253422325" },
                    { 210, "O Restaurante 7 Saias é um restaurante de alta gastronomia em Faro, Algarve. O restaurante é conhecido pela sua comida criativa e inovadora, ambiente elegante e serviço impecável.   ", "/imgpaises/img Portugal/Restaurantes/Restaurante 7 Saias (Faro).png", "De Quarta a sábado das 19h30 às 22h30 e de Domingo a terça é Fechado ", -39.597422042903332, "Rua do Prior, 20, 8000-336 Faro  ", -9.0714648475496968, "Restaurante 7 Saias (Faro)", 6, "+351 289823997" },
                    { 211, "O Palácio Nacional de Mafra é um conjunto monumental barroco do século XVIII, situado na cidade de Mafra, a cerca de 30 km de Lisboa. O conjunto inclui o Palácio, a Basílica, o Convento e a Tapada Nacional de Mafra.  ", "/imgpaises/img Portugal/Cultura/Palácio Nacional de Mafra (Mafra).png", "De Terça a domingo das 9h às 18h (última entrada às 17h30) e Fechado em 25 de dezembro e 1 de janeiro  ", -38.937150613254424, "Terreiro D. João V, 2640-504 Mafra,  ", -9.3260584494357861, "Palácio Nacional de Mafra (Mafra)", 6, "+351 219851000 " },
                    { 212, "A Universidade de Coimbra (UC) é a mais antiga universidade de Portugal e uma das mais antigas da Europa. Foi fundada em 1290 e está classificada como Património Mundial da UNESCO desde 2013.   ", "/imgpaises/img Portugal/Cultura/Universidade de Coimbra (Coimbra).png", "De segunda a sexta das 9h até as 18h ", -40.207876988908637, "Paço das Escolas, Largo da Portagem, 3000-456 Coimbra  ", -8.4261146610120061, "Universidade de Coimbra (Coimbra) ", 6, "+351 239 802 000  " },
                    { 213, "O Palácio da Pena é um palácio romântico do século XIX, situado no topo da Serra de Sintra, a cerca de 30 km de Lisboa. O palácio foi mandado construir pelo rei D. Fernando II e é considerado um dos mais belos exemplos da arquitetura romântica do século XIX.", "/imgpaises/img Portugal/Cultura/Palácio da Pena (Sintra).png", "De Outubro a abril das 10h às 18h (última entrada às 17h), Maio a setembro das 10h às 19h (última entrada às 18h)e  Fechado em 25 de dezembro e 1 de janeiro ", -38.787702151495722, "Estrada da Pena, Sintra 2710-605  ", -9.3906625475859595, "Palácio da Pena (Sintra) ", 6, "+351 21 923 7300 " },
                    { 214, "A Torre de Belém é uma torre fortificada do século XVI, situada na margem direita do rio Tejo, em Lisboa. A torre foi mandada construir pelo rei D. Manuel I e é considerada um dos mais importantes monumentos da arquitetura manuelina.    ", "/imgpaises/img Portugal/Cultura/Torre de Belém (Lisboa).png", "De Terça a domingo das 10h às 18h (última entrada às 17h30) e Fechado em 1 de janeiro, Domingo de Páscoa, 1 de maio e 25 de dezembro ", -38.691809771982797, "Avenida Brasília, 1400-038 Lisboa  ", -9.215880743877257, "Torre de Belém (Lisboa) ", 6, "+351 21 362 0049  " },
                    { 215, "O Convento de Cristo é um monumento religioso e militar do século XII, situado na cidade de Tomar, a cerca de 130 km de Lisboa. O convento foi fundado pelos Templários e é considerado um dos mais importantes monumentos da arquitetura portuguesa     ", "/imgpaises/img Portugal/Cultura/Convento de Cristo (Tomar).png", "De Novembro a abril das 9h às 18h (última entrada às 17h30), Maio a outubro das 9h às 19h (última entrada às 18h30) e Fechado em 25 de dezembro e 1 de janeiro  ", -39.603547098603968, ": Convento de Cristo, Largo do Convento de Cristo, 2300-312 Tomar ", -8.418917072673116, "Convento de Cristo (Tomar)", 6, "+351 249 315 040  " },
                    { 216, "A Fortaleza de Sagres é uma fortaleza militar do século XV, situada no extremo sudoeste da Europa, na cidade de Sagres, a cerca de 50 km de Lagos. A fortaleza foi mandada construir pelo Infante D. Henrique e é considerada um dos mais importantes monumentos da história da navegação portuguesa.    ", "/imgpaises/img Portugal/Cultura/Fortaleza de Sagres (Sagres).png", "De Novembro a abril das 10h às 17h30 (última entrada às 17h), Maio a outubro das 10h às 19h (última entrada às 18h) e Fechado em 25 de dezembro e 1 de janeiro  ", -37.000957964034804, "8650-356 Sagres  ", -8.94824723231687, "Fortaleza de Sagres (Sagres) ", 6, "+351 282 630 337   " },
                    { 217, "Famoso pelas impressionantes Cataratas do Iguaçu, o parque abriga uma rica biodiversidade e trilhas para caminhadas.", "/imgpaises/imgBrasil/Natureza/Parque Nacional do Iguaçu.png", "9h às 17h", -25.6953, "Rodovia BR-469, Km 18, Parque Nacional do Iguaçu, Foz do Iguaçu, PR", -54.436700000000002, "Parque Nacional do Iguaçu", 1, "+55 45 523 8111" },
                    { 218, "Um espaço com mais de 8.000 espécies de plantas, ideal para caminhadas, piqueniques e observação da natureza.", "/imgpaises/imgBrasil/Natureza/Jardim Botânico do Rio de Janeiro.png", "8h às 17h", -22.955200000000001, "Rua Jardim Botânico, 1008, Jardim Botânico, Rio de Janeiro, RJ", -43.223700000000001, "Jardim Botânico do Rio de Janeiro", 1, "+55 21 3874 1808" },
                    { 219, "Conhecido por suas cachoeiras, formações rochosas e rica fauna e flora, ideal para ecoturismo e trilhas.", "/imgpaises/imgBrasil/Natureza/Parque Nacional da Chapada dos Veadeiros.png", "8h às 17h", -14.166399999999999, "Estrada Parque, Km 0, Alto Paraíso de Goiás, GO", -47.3566, "Parque Nacional da Chapada dos Veadeiros", 1, "+55 61 3371 2200" },
                    { 220, "Um dos maiores zoológicos do Brasil, com diversas espécies de animais e um grande espaço verde para visitação.", "/imgpaises/imgBrasil/Natureza/Zoológico de São Paulo.png", "9h às 17h", -23.607600000000001, "Av. Miguel Estefano, 4241, Água Funda, São Paulo, SP", -46.703099999999999, "Zoológico de São Paulo", 1, "+55 11 5080 7399" },
                    { 221, "Conhecido por suas montanhas, trilhas e cachoeiras, é um paraíso para os amantes do trekking e da natureza.", "/imgpaises/imgBrasil/Natureza/Parque Nacional da Serra dos Órgãos.png", "8h às 17h", -22.4086, "Estrada do Parque Nacional, s/n - Vale do Cuiabá, Teresópolis, RJ", -42.979900000000001, "Parque Nacional da Serra dos Órgãos", 1, "+55 21 2742 2335" },
                    { 222, "Um dos maiores parques urbanos do Brasil, com áreas verdes, lagoas e trilhas para caminhada e ciclismo.", "/imgpaises/imgBrasil/Natureza/Parque da Cidade.png", "6h às 18h", -15.975, "SGAS 915, 915, Asa Sul, Brasília, DF", -47.9636, "Parque da Cidade", 1, "+55 61 3226 1006" },
                    { 223, "Restaurante premiado comandado pelo chef Alex Atala, conhecido por sua culinária brasileira inovadora com ingredientes da Amazônia.", "/imgpaises/imgBrasil/Restaurantes/D.O.M.png", "12h às 15h, 19h às 23h", -23.5641, "Rua Barão de Capanema, 549 - Jardim Paulista, São Paulo, SP", -46.661200000000001, "D.O.M.", 1, "+55 11 3088 0761" },
                    { 224, "Restaurante sofisticado de frente para o mar, oferecendo uma culinária italiana refinada e vistas incríveis de Ipanema.", "/imgpaises/imgBrasil/Restaurantes/Fasano Rio.png", "12h às 16h, 19h às 23h", -22.9847, "Av. Vieira Souto, 80 - Ipanema, Rio de Janeiro, RJ", -43.204599999999999, "Fasano Rio", 1, "+55 21 3202 4000" },
                    { 225, "Famoso por seu menu baseado em carne suína, o restaurante do chef Jefferson Rueda é um dos mais badalados da gastronomia paulista.", "/imgpaises/imgBrasil/Restaurantes/Casa do Porco.png", "12h às 23h", -23.546099999999999, "R. Araújo, 124 - República, São Paulo, SP", -46.641199999999998, "Casa do Porco", 1, "+55 11 3258 2578" },
                    { 226, "Comandado pela chef Helena Rizzo, o Maní oferece uma culinária contemporânea brasileira com ênfase em técnicas inovadoras e ingredientes locais.", "/imgpaises/imgBrasil/Restaurantes/Maní.png", "12h às 15h, 19h às 23h", -23.566500000000001, "Rua Joaquim Antunes, 210 - Jardim Paulistano, São Paulo, SP", -46.679000000000002, "Maní", 1, "+55 11 3085 4148" },
                    { 227, "Restaurante estrelado pelo chef Felipe Bronze, onde a criatividade e o uso de técnicas modernas são combinados com ingredientes brasileiros.", "/imgpaises/imgBrasil/Restaurantes/Oro.png", "12h às 15h, 19h às 23h", -22.987200000000001, "Av. General San Martin, 889 - Leblon, Rio de Janeiro, RJ", -43.222000000000001, "Oro", 1, "+55 21 2540 8768" },
                    { 228, "Situado à beira-mar, o Amado oferece uma cozinha contemporânea com influências baianas e vistas deslumbrantes da Baía de Todos-os-Santos.", "/imgpaises/imgBrasil/Restaurantes/amado.png", "12h às 16h, 19h às 23h", -12.9718, "Av. Contorno, 100 - Comércio, Salvador, BA", -38.514800000000001, "Amado", 1, "+55 71 3322 3520" },
                    { 229, "Famosa por seus bares, baladas e casas de shows, a Rua Augusta é um dos principais pontos de vida noturna de São Paulo.", "/imgpaises/imgBrasil/VidaNoturna/Rua Augusta.png", "Varía conforme o estabelecimento", -23.558800000000002, "Rua Augusta, São Paulo, SP", -46.654899999999998, "Rua Augusta", 1, "" },
                    { 230, "Um dos bairros mais icônicos do Rio, conhecido por seus bares, samba e festas animadas.", "/imgpaises/imgBrasil/VidaNoturna/Lapa.png", "Varía conforme o estabelecimento", -22.91, "Lapa, Rio de Janeiro, RJ", -43.195999999999998, "Lapa", 1, "" },
                    { 231, "Um famoso bar de praia em Ipanema, ideal para drinks e música ao vivo em um ambiente descontraído.", "/imgpaises/imgBrasil/VidaNoturna/Barraca do Lulu.png", "10h às 22h", -22.987400000000001, "Praia de Ipanema, Rio de Janeiro, RJ", -43.202199999999998, "Barraca do Lulu", 1, "+55 21 99714 1799" },
                    { 232, "Um espaço cultural e de eventos com música ao vivo, arte e uma atmosfera única.", "/imgpaises/imgBrasil/VidaNoturna/Casa da Luz.png", "18h às 2h", -22.9116, "Rua Marivaldo, 43 - Santa Teresa, Rio de Janeiro, RJ", -43.1965, "Casa da Luz", 1, "+55 21 2332 8670" },
                    { 233, "Um famoso ponto turístico com grafites incríveis e cercado por bares e restaurantes animados na Vila Madalena.", "/imgpaises/imgBrasil/VidaNoturna/Beco do Batman.png", "Varía conforme o estabelecimento", -23.554300000000001, "R. Gonçalo Afonso, 47 - Vila Madalena, São Paulo, SP", -46.699800000000003, "Beco do Batman", 1, "" },
                    { 234, "Um bar tradicional no coração de Ipanema, conhecido por seus petiscos e ambiente descontraído.", "/imgpaises/imgBrasil/VidaNoturna/Pérola Bar.png", "17h às 2h", -22.986499999999999, "R. dos Três Irmãos, 38 - Ipanema, Rio de Janeiro, RJ", -43.203699999999998, "Pérola Bar", 1, "+55 21 2512 1034" },
                    { 235, "O maior templo católico do Brasil, dedicado à Padroeira do Brasil, Nossa Senhora Aparecida. É um ponto de peregrinação e devoção para milhões de fiéis.", "/imgpaises/imgBrasil/Fe/Santuário Nacional de Nossa Senhora Aparecida.png", "6h às 20h", -22.846599999999999, "Avenida Dr. Júlio Prestes, s/n - Aparecida, São Paulo, SP", -45.2303, "Santuário Nacional de Nossa Senhora Aparecida", 1, "+55 12 3104 1000" },
                    { 236, "Um dos mosteiros mais antigos do Brasil, famoso por sua arquitetura histórica e as missas com canto gregoriano.", "/imgpaises/imgBrasil/Fe/Mosteiro de São Bento.png", "6h às 18h", -23.545100000000001, "Largo de São Bento, s/n - Centro, São Paulo, SP", -46.633800000000001, "Mosteiro de São Bento", 1, "+55 11 3328 8799" },
                    { 237, "Uma imponente réplica do Templo de Salomão, construída pela Igreja Universal, que atrai milhares de visitantes em busca de espiritualidade e fé.", "/imgpaises/imgBrasil/Fe/Templo de Salomão.png", "9h às 21h", -23.537600000000001, "Av. Celso Garcia, 605 - Brás, São Paulo, SP", -46.611699999999999, "Templo de Salomão", 1, "+55 11 3573 3535" },
                    { 238, "Famosa por sua arquitetura moderna e impressionante, a catedral é um dos marcos de Brasília e um local de adoração e contemplação.", "/imgpaises/imgBrasil/Fe/Catedral de Brasília.png", "8h às 18h", -15.798, "Esplanada dos Ministérios, Brasília, DF", -47.875300000000003, "Catedral de Brasília", 1, "+55 61 3224 4073" },
                    { 239, "A Igreja Universal do Reino de Deus é uma das maiores denominações evangélicas do Brasil, conhecida por seu foco em milagres, libertação e a pregação do evangelho. Oferece cultos, reuniões de oração e aconselhamentos espirituais.", "/imgpaises/imgBrasil/Fe/Igreja Universal do Reino de Deus.png", "8h às 20h", -23.546199999999999, "Avenida João Ribeiro, 158 - Brás, São Paulo, SP", -46.634599999999999, "Igreja Universal do Reino de Deus", 1, "+55 11 3223 2100" },
                    { 240, "Um dos maiores exemplos do barroco brasileiro, projetada por Aleijadinho, a igreja é um símbolo da arte e da fé no Brasil colonial.", "/imgpaises/imgBrasil/Fe/Igreja de São Francisco de Assis.png", "8h às 17h", -20.386099999999999, "Praça Minas Gerais, Ouro Preto, MG", -43.503399999999999, "Igreja de São Francisco de Assis", 1, "+55 31 3551 4736" },
                    { 241, "Um dos shoppings mais sofisticados de São Paulo, com diversas lojas de grife, restaurantes e opções de entretenimento.", "/imgpaises/imgBrasil/Compras/Shopping Iguatemi.png", "10h às 22h", -23.5715, "Av. Brigadeiro Faria Lima, 2232, Jardim Paulistano, São Paulo, SP", -46.693600000000004, "Shopping Iguatemi", 1, "+55 11 3816 3333" },
                    { 242, "Um shopping elegante localizado no Leblon, com diversas lojas de luxo e opções gastronômicas.", "/imgpaises/imgBrasil/Compras/Shopping Leblon.png", "10h às 22h", -22.984100000000002, "Av. Afrânio de Melo Franco, 290 - Leblon, Rio de Janeiro, RJ", -43.2136, "Shopping Leblon", 1, "+55 21 3204 2000" },
                    { 243, "Um dos maiores shoppings do Brasil, com uma ampla variedade de lojas, cinema e opções de lazer.", "/imgpaises/imgBrasil/Compras/Shopping Barra.png", "10h às 22h", -22.9955, "Av. das Américas, 4666 - Barra da Tijuca, Rio de Janeiro, RJ", -43.364600000000003, "Shopping Barra", 1, "+55 21 2430 8100" },
                    { 244, "O primeiro shopping center do Nordeste, com uma grande variedade de lojas e opções de entretenimento.", "/imgpaises/imgBrasil/Compras/Shopping Recife.png", "10h às 22h", -8.0475999999999992, "Av. Agamenon Magalhães, s/n - Santo Amaro, Recife, PE", -34.895000000000003, "Shopping Recife", 1, "+55 81 3231 3600" },
                    { 245, "Um shopping que combina cultura, compras e gastronomia em um ambiente sofisticado.", "/imgpaises/imgBrasil/Compras/Pátio Higienópolis.png", "10h às 22h", -23.5505, "Rua Dr. Veiga Filho, 133 - Higienópolis, São Paulo, SP", -46.654299999999999, "Pátio Higienópolis", 1, "+55 11 3821 5000" },
                    { 246, "Um dos maiores shoppings da Bahia, com diversas lojas, cinema e opções de alimentação.", "/imgpaises/imgBrasil/Compras/Shopping Salvador.png", "9h às 22h", -12.996, "Av. Luis Viana, 8543 - Paralela, Salvador, BA", -38.467700000000001, "Shopping Salvador", 1, "+55 71 3480 7000" },
                    { 247, "Um dos museus mais importantes do Brasil, com uma vasta coleção de arte ocidental, além de exposições temporárias de grande relevância.", "/imgpaises/imgBrasil/Cultura/Museu de Arte de São Paulo (MASP).png", "10h às 18h", -23.561399999999999, "Avenida Paulista, 1578 - Bela Vista, São Paulo, SP", -46.655900000000003, "Museu de Arte de São Paulo (MASP)", 1, "+55 11 3149 5959" },
                    { 248, "Museu de ciência e inovação com foco no futuro e no impacto das ações humanas no planeta. A arquitetura futurista é uma atração à parte.", "/imgpaises/imgBrasil/Cultura/Museu do Amanhã.png", "10h às 18h", -22.8964, "Praça Mauá, 1 - Centro, Rio de Janeiro, RJ", -43.181899999999999, "Museu do Amanhã", 1, "+55 21 3812 1800" },
                    { 249, "Maior museu a céu aberto do mundo, com um acervo de arte contemporânea em meio a um jardim botânico deslumbrante. Inhotim oferece uma experiência única.", "/imgpaises/imgBrasil/Cultura/Instituto Inhotim.png", "9h30 às 16h30", -20.133400000000002, "Rua B, 20 - Brumadinho, MG", -44.1997, "Instituto Inhotim", 1, "+55 31 3571 9700" },
                    { 250, "O CCBB de Brasília é um dos principais centros culturais do país, com uma programação variada de exposições, teatro, cinema e eventos culturais.", "/imgpaises/imgBrasil/Cultura/Centro Cultural Banco do Brasil (CCBB) - Brasília.png", "9h às 21h", -15.8009, "Setor de Clubes Sul, Trecho 2 - Lote 22 - Brasília, DF", -47.881399999999999, "Centro Cultural Banco do Brasil (CCBB) - Brasília", 1, "+55 61 3108 7600" },
                    { 251, "Símbolo do ciclo da borracha, o Teatro Amazonas é uma das construções mais icônicas do Brasil, com uma arquitetura grandiosa e rica programação cultural.", "/imgpaises/imgBrasil/Cultura/Teatro Amazonas.png", "9h às 17h", -3.1318999999999999, "Av. Eduardo Ribeiro, 659 - Centro, Manaus, AM", -60.023099999999999, "Teatro Amazonas", 1, "+55 92 3622 1880" },
                    { 252, "O coração cultural de Salvador, o Pelourinho é um centro de preservação do patrimônio histórico e cultural, com suas ruas de pedra e construções coloniais.", "/imgpaises/imgBrasil/Cultura/Pelourinho.png", "24h", -12.971399999999999, "Largo do Pelourinho - Centro Histórico, Salvador, BA", -38.509700000000002, "Pelourinho", 1, "+55 71 3324 4488" },
                    { 253, "A maior barreira de coral do mundo, um Patrimônio Mundial da UNESCO. Oferece uma variedade incrível de vida marinha e atividades como mergulho e snorkeling.", "", "Varia de acordo com as empresas de turismo", -18.284454495545621, "Costa nordeste da Austrália", 147.69781747048719, "Grande Barreira de Coral", 8, "Não possui" },
                    { 254, "Um monólito sagrado para os aborígenes australianos, com uma rica história cultural. Oferece paisagens espetaculares e caminhadas ao redor da base.", "", "Aberto 24 horas", -25.342560283824174, "Território do Norte", 131.03825451157539, "Uluru (Ayers Rock)", 8, "+61 8 8956 1128" },
                    { 255, "Um dos maiores parques nacionais da Austrália, com uma rica biodiversidade, pinturas rupestres aborígenes e paisagens desérticas. Ideal para trilhas e safáris.", "", "Aberto 24 horas", -13.092909562659729, "Território do Norte", 132.39168872401842, "Parque Nacional Kakadu", 8, "+61 8 8938 1120" },
                    { 256, "Uma série de pilhas de calcário formadas pela erosão, localizadas na Grande Oceano Road. Um dos ícones da natureza australiana.", "", "Aberto 24 horas", -38.654479165472168, "Grande Oceano Road, Victoria", 143.10439194560004, "Doze Apóstolos", 8, "Não possui" },
                    { 257, "A floresta tropical mais antiga do mundo, com uma rica biodiversidade e paisagens exuberantes. Ideal para trilhas e observação de pássaros.", "", "Aberto 24 horas", -16.168648396918627, "Queensland", 145.41707107799928, "Floresta Tropical de Daintree", 8, "Não possui" },
                    { 258, "A maior ilha de areia do mundo, com dunas, lagos cristalinos e florestas. Ideal para 4x4, camping e observação da vida selvagem.", "", "Aberto 24 horas", -25.3444, "Queensland", 153.12360000000001, "Fraser Island", 8, "Não possui" },
                    { 259, "Considerado um dos melhores restaurantes da Austrália, o Quay oferece uma experiência gastronômica de alta qualidade com vista espetacular para a Opera House. O chef Peter Gilmore cria pratos inovadores que celebram os produtos sazonais australianos.", "", "Consulte o site oficial para horários atualizados", -33.858029216926781, "The Rocks, Sydney", 151.2100702956208, "Quay (Sydney)", 8, "+61 2 9251 5600" },
                    { 260, "Sydney combina paisagens espetaculares com uma cena gastronômica vibrante. Desfrute de frutos do mar frescos nos restaurantes do Circular Quay, ou explore os diversos bairros como Surry Hills e Chinatown.", "", "Varia de restaurante para restaurante", -37.874406184806915, "Ripponlea, Melbourne", 144.99867885080727, "Attica (Melbourne)", 8, "+61 3 9530 0111" },
                    { 261, "Fundado pelo renomado chef Neil Perry, o Rockpool é um ícone da gastronomia australiana. O restaurante oferece uma ampla variedade de pratos, com destaque para carnes de alta qualidade e frutos do mar frescos.", "", " Consulte o site oficial para horários atualizados", -33.86607057393735, "Várias localizações em Sydney", 151.20951250450756, "Rockpool (Sydney)", 8, "+61 2 8099 7077" },
                    { 262, "Sepia é conhecido por sua cozinha moderna e elegante, com foco em ingredientes sazonais e técnicas culinárias japonesas. O restaurante oferece um menu degustação inovador que muda regularmente.", "", "Consulte o site oficial para horários atualizados", -33.872166529508725, "Surry Hills  (Sydney)", 151.20359342328689, " Sepia (Sydney)", 8, "Não possui" },
                    { 263, "Localizado em uma fazenda nos arredores de Melbourne, Brae oferece uma experiência gastronômica única, com um menu degustação que muda diariamente de acordo com a disponibilidade dos ingredientes frescos da fazenda.", "", "Consulte o site oficial para horários atualizados", -38.346504984376246, "Birregurra (Victoria)", 143.80722130000001, " Brae (Birregurra)", 8, "+61 3 5236 2226" },
                    { 264, "Criado pelo famoso chef David Chang, Momofuku Seiobo oferece uma experiência gastronômica moderna e descontraída, com um menu que mistura influências asiáticas com ingredientes australianos.", "", "Consulte o site oficial para horários atualizados", -33.868818153800405, "Barangaroo (Sydney)", 151.19572048465736, "Momofuku Seiobo (Sydney)", 8, "+61 2 9657 9169" },
                    { 265, "Conhecido como o coração da vida noturna de Sydney, Kings Cross oferece uma variedade de bares, clubes e restaurantes. É um local vibrante e cheio de energia.", "", "Varia de estabelecimento para estabelecimento", -33.873323771097475, "Sydney, Nova Gales do Sul", 151.22422985043181, "Kings Cross, Sydney", 8, "(02) 9331 9900" },
                    { 266, "O centro de Melbourne é um labirinto de bares, restaurantes e clubes. Desde bares de jazz até clubes underground, há algo para todos os gostos.", "", "Varia de estabelecimento para estabelecimento", -37.810166598097403, "Melbourne, Victoria", 144.96164715611181, "Melbourne CBD", 8, "+61 3 9658 9658" },
                    { 267, "Um dos clubes mais famosos da Austrália, o Ivy é um complexo de entretenimento com várias áreas, incluindo um restaurante, bar e pista de dança. A programação musical é variada, com DJs tocando os últimos hits.", "", "Varia de acordo com o dia da semana e evento. Consulte o site oficial para horários atualizados.", -33.86639531322637, "Sydney CBD", 151.2075121107099, "Ivy (Sydney)", 8, "+61 2 9240 3000" },
                    { 268, "Um dos bares de praia mais famosos da Austrália, o The Beach oferece vistas espetaculares do oceano Pacífico. É o lugar perfeito para tomar um drink enquanto admira o pôr do sol.", "", " Varia de acordo com a estação.", -33.891448064008806, "Bondi Beach, Sydney", 151.27599320605552, " The Beach, Bondi (Sydney)", 8, "(02) 9130 7247" },
                    { 269, " Inspirado nos clubes de Nova York dos anos 1920, o Cloudland é um local elegante e sofisticado, com decoração luxuosa e música ao vivo.", "", "Varia de acordo com o dia da semana e evento.", -27.458229554203985, "Fortitude Valley, Brisbane", 153.03490788956412, "Cloudland (Brisbane)", 8, "+61 7 3872 6600" },
                    { 270, "Um dos clubes mais populares de Melbourne, The Bird é conhecido por sua música eletrônica e atmosfera vibrante.", "", "Varia de acordo com o dia da semana e evento. Consulte o site oficial para horários atualizados.", -37.808745319025711, "Melbourne CBD", 144.9577479697401, "The Bird (Melbourne)", 8, "Não possui" },
                    { 271, "A maior catedral católica da Austrália, com uma arquitetura neogótica impressionante. Um marco histórico e espiritual da cidade de Sydney.", "", "Diariamente, 07h00 às 19h00", -33.871025700485021, "Sydney, New South Wales", 151.21338977301392, "St. Mary's Cathedral, Sydney", 8, "+61 2 9220 0400" },
                    { 272, "A maior catedral católica da Austrália, com uma rica história e arquitetura gótica. Um local de peregrinação para muitos católicos australianos.", "", "Diariamente, 07h00 às 19h00", -37.809934964845247, "Melbourne, Victoria", 144.97647034417824, "St. Patrick's Cathedral, Melbourne", 8, "03 9662 2233" },
                    { 273, "A Mesquita de Melbourne é a maior mesquita da Austrália. Sua arquitetura islâmica impressionante e os jardins tranquilos oferecem um refúgio para a comunidade muçulmana e para todos aqueles que buscam um momento de paz.", "", " Consulte o site oficial para horários de oração.", -37.818019039589863, "Hoppers Crossing (Melbourne)", 144.98288072401331, "Mesquita de Melbourne (Melbourne)", 8, "Não possui" },
                    { 274, "O Templo Chinês de Melbourne é um dos maiores templos budistas fora da China. Sua arquitetura elaborada e os jardins exuberantes criam um ambiente sereno e inspirador.", "", "Diariamente, das 9h às 17h.", -37.836665168697905, "Melbourne CBD", 144.96324509999999, "Templo Chinês de Melbourne (Melbourne)", 8, "Não possui" },
                    { 275, "O maior templo hindu da Austrália, dedicado a Lord Venkateswara, oferece um ambiente colorido e vibrante para a prática religiosa. A arquitetura elaborada e os rituais religiosos criam uma atmosfera única.", "", "Diariamente, consulte o site oficial para horários de puja (oração)", -33.029137081703965, "O templo foi construído no topo de uma colina a 120 metros acima do nível do mar.", 152.24249413814792, "Templo Sri Venkateswara, Melbourne", 8, "Não possui" },
                    { 276, "Um dos maiores templos budistas fora da Ásia, o Nan Tien oferece um retiro espiritual completo, com templos, jardins, um centro de meditação e um instituto budista.", "", "Diariamente, consulte o site oficial para horários de meditação e eventos.", -34.465869468514718, "Wollongong (Nova Gales do Sul)", 150.84850884439629, "Nan Tien Temple (Wollongong)", 8, "+61 2 4272 0600" },
                    { 277, "Um dos maiores mercados públicos do Hemisfério Sul, oferecendo uma vasta gama de produtos, desde frutas e legumes frescos até roupas, artesanato e souvenirs. Um ótimo lugar para experimentar a cultura local e encontrar produtos únicos.", "", "Variável, consulte o site oficial", -37.807347223191265, "Melbourne", 144.95673266657596, "Queen Victoria Market", 8, "+61 3 9320 5822" },
                    { 278, "Uma das principais ruas comerciais de Sydney, com lojas de marcas internacionais, boutiques e grandes armazéns. Um destino popular para quem busca moda e acessórios.", "", "Varia de loja para loja", -33.869482113113264, "Sydney", 151.20859334044431, "Pitt Street Mall", 8, "Não possui" },
                    { 279, "Uma rua conhecida por suas lojas vintage, boutiques independentes e cafés charmosos. Um lugar ideal para quem busca peças únicas e um ambiente mais alternativo.", "", "Varia de loja para loja", -37.853167467111582, "Melbourne", 144.99314134062274, "Chapel Street", 8, "Não possui" },
                    { 280, "Uma das maiores redes de lojas de departamentos da Austrália, oferecendo uma ampla variedade de produtos, desde moda e beleza até eletrodomésticos e artigos para casa.", "", "Varia de loja para loja", -34.005971651605591, "Várias cidades (Sydney, Melbourne, Brisbane, etc.)", 138.88094509840045, "Myer Centre", 8, "+61 8 8212 1200" },
                    { 281, "Uma das principais ruas comerciais de Brisbane, com lojas de marcas internacionais, boutiques e centros comerciais. Um ótimo lugar para fazer compras ao ar livre.", "", "Varia de loja para loja", -27.469331635865686, "Brisbane", 153.02529526718047, "Queen Street Mall", 8, "+61 7 3403 8888" },
                    { 282, "Adelaide é conhecida por seus diversos mercados, como o Central Market e o Adelaide Central Market Arcade. Estes oferecem uma variedade de produtos frescos, artesanato local e comidas deliciosas.", "", "Variável, consulte o site oficial", -34.921902913454595, "Adelaide", 138.59902553627143, "Markets of Adelaide", 8, "+61 8 8203 7494" },
                    { 283, "Ícone da Austrália, a Ópera de Sydney é uma obra-prima da arquitetura moderna e um Patrimônio Mundial da UNESCO. Além dos espetáculos, oferece tours guiados e vistas deslumbrantes da cidade.", "", "Varia de acordo com a atração", -33.856610636313498, "Sydney, Nova Gales do Sul", 151.21533961160804, "Sydney Opera House", 8, "+61 2 9250 7111" },
                    { 284, "Construído para a Exposição Internacional de 1880, o Royal Exhibition Building é um marco da arquitetura vitoriana e um Patrimônio Mundial da UNESCO. Hoje, ele abriga o Museu Melbourne e diversos eventos culturais.", "", "Varia de acordo com os eventos, consulte o site oficial.", -37.804515295216014, "Melbourne (Victoria)", 144.97166092527775, "Royal Exhibition Building (Melbourne)", 8, "+61 131102" },
                    { 285, "O antigo prédio do Parlamento australiano é um testemunho da história política do país. Hoje, ele abriga o Museu da Democracia, que explora a história da democracia australiana e o papel do Parlamento.", "", "Diariamente, consulte o site oficial para horários.", -35.302076119326806, "Canberra (Território da Capital Australiana)", 149.12973409632815, " Old Parliament House (Canberra)", 8, "+61 2 6270 8222" },
                    { 286, "Um memorial dedicado aos australianos que serviram nas forças armadas. Abriga coleções, exposições e um cenotáfio, contando a história militar da Austrália.", "", "Diariamente, 10h00 às 17h00", -35.281008478037741, "Canberra, Território da Capital Australiana", 149.14848634050563, "Australian War Memorial", 8, "+61 2 6243 4211" },
                    { 287, "Construído em estilo vitoriano, o Queen Victoria Building é um dos shoppings mais antigos de Sydney. Sua arquitetura imponente e as lojas de luxo fazem dele um destino popular para compras e para conhecer um pouco da história da cidade.", "", "Diariamente, das 9h às 18h.", -33.871566082771189, "Sydney (Nova Gales do Sul)", 151.20681508462258, "Queen Victoria Building (Sydney)", 8, "+61 2 9265 6800" },
                    { 288, "Um sítio histórico que conta a história da colonização penal da Tasmânia. Um local sombrio, mas importante para entender o passado da Austrália.", "", "Varia de acordo com a época do ano", -43.145487137733632, "Tasmânia", 147.8506213813647, "Port Arthur Historic Site", 8, "+61 (0)3 6251 2310" },
                    { 289, "Um dos parques nacionais mais populares da Coreia do Sul, conhecido por suas montanhas majestosas, trilhas desafiadoras e paisagens deslumbrantes. O pico mais alto, o Seoraksan, oferece vistas panorâmicas espetaculares.", "https://www.example.com/seoraksan_national_park.jpg", "Todos os dias da 09:00- 18:00", 38.162040054168628, "Sokcho, Gangwon-do", 128.43547951753388, "Seoraksan National Park", 9, " +82 33-801-0900" },
                    { 290, "A maior ilha da Coreia do Sul, famosa por suas belas praias, vulcões adormecidos, cachoeiras e a Ilha Hallasan, o ponto mais alto da Coreia do Sul. Um destino popular para lua de mel.", "https://www.example.com/ilha_de_jeju.jpg", "24 horas", 33.381994844092603, "Mar do Sul da Coreia", 126.56739146760108, "Ilha de Jeju", 9, "Não possui" },
                    { 291, "Um parque nacional facilmente acessível a partir de Seul, oferecendo uma variedade de trilhas para caminhadas e escalada. É um ótimo lugar para fugir da agitação da cidade e apreciar a natureza.", "https://www.example.com/bukhansan_national_park.jpg", "Todos os dias das 04:00–17:00", 37.619183288027905, "Seul e Gyeonggi-do", 126.99695839666964, "Bukhansan National Park", 9, "Não possui" },
                    { 292, "Juknokwon é a floresta de bambu mais renomada da Coreia do Sul, oferecendo uma mistura única de beleza natural e herança cultural. Aninhada em Damyang, o coração da Poesia Coreana Clássica da Dinastia Joseon, Juknokwon apresenta uma densa floresta de bambu e uma vila cultural de pavilhões.", "https://www.example.com/gyeongbokgung_palace.jpg", "Todos os dias 09:00–18:00", 35.339839452939394, "Damyang", 127.04863580520106, "Juknokwon", 9, "Não possui" },
                    { 293, "Um rio urbano revitalizado que corta o centro de Seul. Um ótimo lugar para um passeio relaxante, com paisagismo exuberante e pontes charmosas.", "https://www.example.com/cheonggyecheon_stream.jpg", "24 horas", 37.571407361070051, "Seul", 126.97883994360866, "Cheonggyecheon Stream", 9, "Não possui" },
                    { 294, "Uma ilha vulcânica com paisagens dramáticas, incluindo falésias, cavernas e cachoeiras. É um destino popular para quem busca aventuras ao ar livre e paisagens únicas.", "https://www.example.com/ulleungdo_island.jpg", "24 horas", 37.508101591795793, "Mar do Leste da Coreia", 130.85698171738426, "Ulleungdo Island", 9, "" },
                    { 295, "Restaurante de alta gastronomia com pratos coreanos contemporâneos.", "https://www.example.com/myeongdong_food.jpg", " Segunda-feira a domingo, das 12h às 15h e das 17h30 às 22h.", 37.525880264601184, "Seul", 127.04104456015547, "Jungsik Seoul", 9, " +82 2-517-4654" },
                    { 296, "  Restaurante de comida de rua coreana com pratos tradicionais e modernos.", "https://www.example.com/namdaemun_food.jpg", "Todos os Dias 17:00–00:00", 37.561266653553076, "Seul", 126.9204677408502, "Hangong-Gan", 9, "+821072234247" },
                    { 297, "Restaurante de tacos mexicanos com ingredientes frescos e autênticos.", "https://www.example.com/gwangjang_market_food.jpg", "Terça a Domindo das 11:30–21:00", 37.551514700472801, "Seul", 126.92417224226679, "Gusto Taco", 9, "+82 2-338-8226" },
                    { 298, "Restaurante de churrasco brasileiro com carnes grelhadas e acompanhamentos.).", "https://www.example.com/insadong_restaurant.jpg", "De Terça a Domingo, 12:00–22:00", 37.538975573074808, "Seul", 126.98970825048039, "Copacabana Grill", 9, "+82 2-796-1660" },
                    { 299, "Restaurante de churrasco sul-africano com carnes grelhadas e acompanhamentos.", "https://www.example.com/gangnam_restaurant.jpg", "Segunda-feira, das 17h às 21h. Terça-feira a sábado, das 12h às 21h. Domingo, das 12h às 20h30.", 36.966148797274222, "Seul", 127.04390477691267, "Braai Republic", 9, " +82 31-657-7580" },
                    { 300, "Restaurante de caldos de mandu (bolinhos de carne) e kalguksu (macarrão de massa fina).", "https://www.example.com/jeju_seafood.jpg", "Segunda-feira a domingo, das 11h às 22h.", 37.568076793506258, "Seoul", 126.98423216079435, "Myeongdong Kyoja", 9, " +82 2-776-5348" },
                    { 301, "Considerada uma das maiores e mais famosas boates da Ásia, o Octagon é conhecido por sua música eletrônica, DJs renomados e ambiente luxuoso. É um ponto de encontro para a elite e amantes da música eletrônica.", "https://www.example.com/octagon_seoul.jpg", "Varia de acordo com a noite", 37.671613968424538, "Gangnam, Seul", 126.78319992538519, "Octagon", 9, " +821073288182" },
                    { 302, "Outra grande boate em Gangnam, o Ellui é conhecido por sua atmosfera vibrante e música variada. É um lugar popular para quem busca uma noite de dança e diversão.", "https://www.example.com/ellui_seul.jpg", "Varia de acordo com a noite", 37.526219712374321, "Gangnam, Seul", 127.05424524232673, "Ellui", 9, " +8225188556" },
                    { 303, "Localizado no bairro multicultural de Itaewon, o NB2 é conhecido por sua atmosfera internacional e música variada. É um lugar popular para quem busca uma noite divertida e multicultural.", "https://www.example.com/nb2_seoul.jpg", "Varia de acordo com a noite", 37.550977824366974, "Itaewon, Seul", 126.92321046930688, "NB2", 9, " +821085550856" },
                    { 304, "Localizado no vibrante bairro de Hongdae, o Club Aura é conhecido por sua música eletrônica e atmosfera jovem. É um lugar popular para estudantes e jovens adultos.", "https://www.example.com/arena_seoul.jpg", "Varia de acordo com a noite", 37.553065552028634, "Hongdae, Seul", 126.92185292159981, "Hongdae Club Aura", 9, " +821066676460" },
                    { 305, "Um Local de dança para descontrai e se divertir a noite", "https://www.example.com/masquerade_seul.jpg", "Todods os dias: 20:00–02:00", 937.51750000000004, "191 Donggyo-ro, Mapo-gu, Seoul, Coreia do Sul", 127.0275, "Club Bonita", 9, " +821092183132" },
                    { 306, "Conhecido por sua música underground e atmosfera alternativa, o Itaewon club Gathering atrai um público mais jovem e descontraído. É um lugar para quem busca uma experiência musical mais autêntica.", "https://www.example.com/club_fabric_seul.jpg", "Varia de acordo com a noite", 37.537720597792983, "Itaewon, Seul", 126.99454040411936, "Itaewon club Gathering", 9, " +821092123793" },
                    { 307, "Um dos templos budistas mais antigos e importantes da Coreia do Sul, conhecido por sua arquitetura deslumbrante e esculturas budistas. Um Patrimônio Mundial da UNESCO.", "https://www.example.com/bulguksa_temple.jpg", "Diariamente, 09h00 às 18h00", 35.790334613450185, "Gyeongju, Gyeongsangbuk-do", 129.33206679374007, "Bulguksa Temple", 9, " +82547469913" },
                    { 308, "Uma gruta budista esculpida em uma montanha, abrigando uma estátua de Buda de granito. Famosa por sua harmonia entre natureza e arte budista.", "https://www.example.com/seokguram_grotto.jpg", "Diariamente, 09h00 às 18h00", 35.795315316118931, "Gyeongju, Gyeongsangbuk-do", 129.35042241181617, "Seokguram Grotto", 9, " +82547469933" },
                    { 309, "Um santuário confucionista dedicado aos ancestrais da dinastia Joseon. Um lugar sagrado para cerimônias confucionistas e um exemplo excepcional da arquitetura tradicional coreana.", "https://www.example.com/jongmyo_shrine.jpg", "Diariamente, 09h00 às 18h00", 37.574710520662755, "Seul", 126.99418591189087, "Jongmyo Shrine", 9, " +8227650195" },
                    { 310, "Um templo budista localizado em um penhasco com vista para o mar. Um dos templos mais bonitos da Coreia do Sul, conhecido por sua arquitetura única e localização pitoresca.", "https://www.example.com/haedong_yonggungsa_temple.jpg", "Diariamente, 04h00 às 19h00", 35.188629656940748, "Busan", 129.22328750993472, "Haedong Yonggungsa Temple", 9, " +82517227744" },
                    { 311, "Um dos templos budistas mais antigos de Seul, localizado em um parque urbano. Um lugar tranquilo para meditação e apreciação da natureza.", "https://www.example.com/bongeunsa_temple.jpg", "Diariamente, 04h00 às 19h00", 37.515056213325501, "Seul", 127.05728003701194, "Bongeunsa Temple", 9, " +82232184800" },
                    { 312, "A primeira catedral católica romana da Coreia do Sul, com uma rica história e arquitetura gótica. Um marco importante para a comunidade católica coreana.", "https://www.example.com/jeongdong_cathedral.jpg", "Diariamente, 09h00 às 18h00", 35.813508477630528, "Seul", 127.14931062716347, "Jeongdong Cathedral", 9, " +82632843222" },
                    { 313, "Um dos distritos comerciais mais populares de Seul, conhecido por suas lojas de cosméticos, moda e restaurantes. É um paraíso para os amantes de compras.", "https://www.example.com/myeongdong.jpg", "Varia de loja para loja", 37.560785672420124, "Seul", 126.98585614550366, "Myeongdong", 9, "Não Possui" },
                    { 314, "Um dos mercados tradicionais mais antigos de Seul, oferecendo uma vasta variedade de produtos, desde roupas e acessórios até alimentos e souvenirs.", "https://www.example.com/namdaemun_market.jpg", "De Segunda a Sabado das 09:00–17:00", 37.559250864567474, "Seul", 126.97761555248368, "Namdaemun Market", 9, "+8227532805" },
                    { 315, "Um bairro histórico conhecido por suas lojas de artesanato, galerias de arte e casas de chá tradicionais. É um ótimo lugar para encontrar presentes únicos e experimentar a cultura coreana.", "https://www.example.com/insadong.jpg", "Varia de loja para loja", 37.571966584843238, "Seul", 126.98614014456358, "Insadong", 9, "Não Possui" },
                    { 316, "Conhecido mundialmente pela música K-pop, Gangnam também é um distrito de compras de luxo, com lojas de marcas internacionais e boutiques de moda coreana.", "https://www.example.com/gangnam.jpg", "Varia de loja para loja", 37.503753420280923, "Seul", 127.06245889811935, "Gangnam", 9, "Não Possui" },
                    { 317, "Um complexo de design e compras futurístico, abrigando diversas lojas de moda, restaurantes e espaços de exposições. É um ponto de encontro para os jovens e amantes da moda.", "https://www.example.com/dongdaemun_design_plaza.jpg", "Diariamente, das 10h às 20h", 37.566657386535091, "Seul", 127.00926651201372, "Dongdaemun Design Plaza (DDP)", 9, "+82221530000" },
                    { 318, "Um dos mercados tradicionais mais antigos de Seul, famoso por sua comida de rua e produtos têxteis. É um ótimo lugar para experimentar a culinária coreana e comprar tecidos.", "https://www.example.com/gwangjang_market.jpg", "Diariamente, das 10h às 22h", 37.570839149843785, "Seul", 126.99973234706955, "Mercado de Gwangjang", 9, "Não Possui" },
                    { 319, "O maior e mais representativo dos Cinco Grandes Palácios da Dinastia Joseon, o Gyeongbokgung oferece uma visão da arquitetura tradicional coreana e da vida da realeza.", "https://www.example.com/gyeongbokgung_palace.jpg", "Diariamente, 09h00 às 18h00", 37.579753014697339, "Seul", 126.97694443701472, "Gyeongbokgung Palace", 9, " +82237003900" },
                    { 320, "Uma vila tradicional coreana com casas hanok bem preservadas. Um lugar perfeito para experimentar a vida cotidiana coreana e apreciar a arquitetura tradicional.", "https://www.example.com/bukchon_hanok_village.jpg", "Aberto 24 horas", 37.581694907138093, "Seul", 126.98494116748547, "Bukchon Hanok Village", 9, " +82221331371" },
                    { 321, "A antiga capital do reino de Silla, Gyeongju abriga numerosos túmulos reais, templos budistas e outros monumentos históricos, oferecendo uma visão da história milenar da Coreia.", "https://www.example.com/gyeongju_historic_area.jpg", "Varia de local para local", 35.834269819304161, "Gyeongju, Gyeongsangbuk-do", 129.21686418298106, "Gyeongju Historic Area", 9, " +82547798742" },
                    { 322, "O maior museu da Coreia do Sul, com uma vasta coleção de artefatos que contam a história e a cultura do país desde a pré-história até os tempos modernos.", "https://www.example.com/national_museum_of_korea.jpg", "Diariamente, 10h00 às 18h00", 37.524088824745704, "Seul", 126.98055602723529, "National Museum of Korea", 9, " +82220779000" },
                    { 323, "A zona desmilitarizada que separa as duas Coreias é um lembrete da divisão da península coreana e oferece uma visão única da história recente da região.", "https://www.example.com/dmz.jpg", "Varia de acordo com a excursão", 38.360230188077217, "Fronteira entre a Coreia do Sul e a Coreia do Norte", 127.47325686815884, "DMZ (Zona Desmilitarizada)", 9, " Não tem" },
                    { 324, "Uma vila tradicional coreana bem preservada, com casas hanok, ruas estreitas e mercados tradicionais. Um lugar perfeito para experimentar a vida cotidiana coreana.", "https://www.example.com/jeonju_hanok_village.jpg", "Aberto 24 horas", 35.817798567596171, "Jeonju, Jeollabuk-do", 127.15204169647048, "Jeonju Hanok Village", 9, " +82632821330" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "Cidade", "Descricao", "Foto", "Nome", "Telefone" },
                values: new object[,]
                {
                    { "5a77beee-9a2a-4ac6-b8fb-390c209a2152", "Barra Bonita, SP", "Programador junior", "/img/Criador/Any.png", "Any Gabriele de Lima", "(14)99844-1425" },
                    { "80f41a70-951e-4356-9ec2-8dddc2fc598a", "Mundo Afora", "Viajante profissional, amante de café e contador de histórias ruins.", "/img/User/Joao.jpg", "João Aventureiro Souza", "(00)00000-0000" },
                    { "b6ca8249-53d1-4907-b6e8-dabf2673df15", "Barra Bonita, SP", "Programador junior", "/img/Criador/dametto.png", "Eduardo Dametto", "(14)98112-0019" },
                    { "d99ee5a6-68bc-463d-8e38-c5e471ab55fb", "Barra Bonita, SP", "Programador junior", "/img/Criador/Ana.jpg", "Ana Clara Mello da Silva", "(14)99632-9433" },
                    { "de36459b-fa4d-4eda-bdc3-12b9eb14c516", "Barra Bonita, SP", "Programador junior", "/img/Criador/Nunes.png", "Eduardo Nunes de Oliveira", "(14)99107-8235" }
                });

            migrationBuilder.InsertData(
                table: "ExperienciasLocais",
                columns: new[] { "ExperienciaId", "LocalId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 },
                    { 1, 41 },
                    { 1, 42 },
                    { 1, 73 },
                    { 1, 74 },
                    { 1, 75 },
                    { 1, 76 },
                    { 1, 77 },
                    { 1, 78 },
                    { 1, 109 },
                    { 1, 110 },
                    { 1, 111 },
                    { 1, 112 },
                    { 1, 113 },
                    { 1, 114 },
                    { 1, 145 },
                    { 1, 146 },
                    { 1, 147 },
                    { 1, 148 },
                    { 1, 149 },
                    { 1, 150 },
                    { 1, 181 },
                    { 1, 182 },
                    { 1, 183 },
                    { 1, 184 },
                    { 1, 185 },
                    { 1, 186 },
                    { 1, 217 },
                    { 1, 218 },
                    { 1, 219 },
                    { 1, 220 },
                    { 1, 221 },
                    { 1, 222 },
                    { 1, 253 },
                    { 1, 254 },
                    { 1, 255 },
                    { 1, 256 },
                    { 1, 257 },
                    { 1, 258 },
                    { 1, 289 },
                    { 1, 290 },
                    { 1, 291 },
                    { 1, 292 },
                    { 1, 293 },
                    { 1, 294 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 43 },
                    { 2, 44 },
                    { 2, 45 },
                    { 2, 46 },
                    { 2, 47 },
                    { 2, 48 },
                    { 2, 79 },
                    { 2, 80 },
                    { 2, 81 },
                    { 2, 82 },
                    { 2, 83 },
                    { 2, 84 },
                    { 2, 115 },
                    { 2, 116 },
                    { 2, 117 },
                    { 2, 118 },
                    { 2, 119 },
                    { 2, 120 },
                    { 2, 151 },
                    { 2, 152 },
                    { 2, 153 },
                    { 2, 154 },
                    { 2, 155 },
                    { 2, 156 },
                    { 2, 187 },
                    { 2, 188 },
                    { 2, 189 },
                    { 2, 190 },
                    { 2, 191 },
                    { 2, 192 },
                    { 2, 223 },
                    { 2, 224 },
                    { 2, 225 },
                    { 2, 226 },
                    { 2, 227 },
                    { 2, 228 },
                    { 2, 259 },
                    { 2, 260 },
                    { 2, 261 },
                    { 2, 262 },
                    { 2, 263 },
                    { 2, 264 },
                    { 2, 295 },
                    { 2, 296 },
                    { 2, 297 },
                    { 2, 298 },
                    { 2, 299 },
                    { 2, 300 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 49 },
                    { 3, 50 },
                    { 3, 51 },
                    { 3, 52 },
                    { 3, 53 },
                    { 3, 54 },
                    { 3, 85 },
                    { 3, 86 },
                    { 3, 87 },
                    { 3, 88 },
                    { 3, 89 },
                    { 3, 90 },
                    { 3, 121 },
                    { 3, 122 },
                    { 3, 123 },
                    { 3, 124 },
                    { 3, 125 },
                    { 3, 126 },
                    { 3, 157 },
                    { 3, 158 },
                    { 3, 159 },
                    { 3, 160 },
                    { 3, 161 },
                    { 3, 162 },
                    { 3, 193 },
                    { 3, 194 },
                    { 3, 195 },
                    { 3, 196 },
                    { 3, 197 },
                    { 3, 198 },
                    { 3, 229 },
                    { 3, 230 },
                    { 3, 231 },
                    { 3, 232 },
                    { 3, 233 },
                    { 3, 234 },
                    { 3, 265 },
                    { 3, 266 },
                    { 3, 267 },
                    { 3, 268 },
                    { 3, 269 },
                    { 3, 270 },
                    { 3, 301 },
                    { 3, 302 },
                    { 3, 303 },
                    { 3, 304 },
                    { 3, 305 },
                    { 3, 306 },
                    { 4, 19 },
                    { 4, 20 },
                    { 4, 21 },
                    { 4, 22 },
                    { 4, 23 },
                    { 4, 24 },
                    { 4, 55 },
                    { 4, 56 },
                    { 4, 57 },
                    { 4, 58 },
                    { 4, 59 },
                    { 4, 60 },
                    { 4, 91 },
                    { 4, 92 },
                    { 4, 93 },
                    { 4, 94 },
                    { 4, 95 },
                    { 4, 96 },
                    { 4, 127 },
                    { 4, 128 },
                    { 4, 129 },
                    { 4, 130 },
                    { 4, 131 },
                    { 4, 132 },
                    { 4, 163 },
                    { 4, 164 },
                    { 4, 165 },
                    { 4, 166 },
                    { 4, 167 },
                    { 4, 168 },
                    { 4, 199 },
                    { 4, 200 },
                    { 4, 201 },
                    { 4, 202 },
                    { 4, 203 },
                    { 4, 204 },
                    { 4, 235 },
                    { 4, 236 },
                    { 4, 237 },
                    { 4, 238 },
                    { 4, 239 },
                    { 4, 240 },
                    { 4, 271 },
                    { 4, 272 },
                    { 4, 273 },
                    { 4, 274 },
                    { 4, 275 },
                    { 4, 276 },
                    { 4, 277 },
                    { 4, 307 },
                    { 4, 308 },
                    { 4, 309 },
                    { 4, 310 },
                    { 4, 311 },
                    { 4, 312 },
                    { 5, 25 },
                    { 5, 26 },
                    { 5, 27 },
                    { 5, 28 },
                    { 5, 29 },
                    { 5, 30 },
                    { 5, 61 },
                    { 5, 62 },
                    { 5, 63 },
                    { 5, 64 },
                    { 5, 65 },
                    { 5, 66 },
                    { 5, 97 },
                    { 5, 98 },
                    { 5, 99 },
                    { 5, 100 },
                    { 5, 101 },
                    { 5, 102 },
                    { 5, 133 },
                    { 5, 134 },
                    { 5, 135 },
                    { 5, 136 },
                    { 5, 137 },
                    { 5, 138 },
                    { 5, 169 },
                    { 5, 170 },
                    { 5, 171 },
                    { 5, 172 },
                    { 5, 173 },
                    { 5, 174 },
                    { 5, 205 },
                    { 5, 206 },
                    { 5, 207 },
                    { 5, 208 },
                    { 5, 209 },
                    { 5, 210 },
                    { 5, 241 },
                    { 5, 242 },
                    { 5, 243 },
                    { 5, 244 },
                    { 5, 245 },
                    { 5, 246 },
                    { 5, 278 },
                    { 5, 279 },
                    { 5, 280 },
                    { 5, 281 },
                    { 5, 282 },
                    { 5, 313 },
                    { 5, 314 },
                    { 5, 315 },
                    { 5, 316 },
                    { 5, 317 },
                    { 5, 318 },
                    { 6, 31 },
                    { 6, 32 },
                    { 6, 33 },
                    { 6, 34 },
                    { 6, 35 },
                    { 6, 36 },
                    { 6, 67 },
                    { 6, 68 },
                    { 6, 69 },
                    { 6, 70 },
                    { 6, 71 },
                    { 6, 72 },
                    { 6, 103 },
                    { 6, 104 },
                    { 6, 105 },
                    { 6, 106 },
                    { 6, 107 },
                    { 6, 108 },
                    { 6, 139 },
                    { 6, 140 },
                    { 6, 141 },
                    { 6, 142 },
                    { 6, 143 },
                    { 6, 144 },
                    { 6, 175 },
                    { 6, 176 },
                    { 6, 177 },
                    { 6, 178 },
                    { 6, 179 },
                    { 6, 180 },
                    { 6, 211 },
                    { 6, 212 },
                    { 6, 213 },
                    { 6, 214 },
                    { 6, 215 },
                    { 6, 216 },
                    { 6, 247 },
                    { 6, 248 },
                    { 6, 249 },
                    { 6, 250 },
                    { 6, 251 },
                    { 6, 252 },
                    { 6, 283 },
                    { 6, 284 },
                    { 6, 285 },
                    { 6, 286 },
                    { 6, 287 },
                    { 6, 288 },
                    { 6, 319 },
                    { 6, 320 },
                    { 6, 321 },
                    { 6, 322 },
                    { 6, 323 },
                    { 6, 324 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_PaisId",
                table: "Cidade",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienciasLocais_LocalId",
                table: "ExperienciasLocais",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Lista_LocalId",
                table: "Lista",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Lista_UsuarioId",
                table: "Lista",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Local_PaisId",
                table: "Local",
                column: "PaisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agencia");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Criador");

            migrationBuilder.DropTable(
                name: "ExperienciasLocais");

            migrationBuilder.DropTable(
                name: "Lista");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
