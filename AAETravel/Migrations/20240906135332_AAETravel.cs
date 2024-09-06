using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AAETravel.Migrations
{
    /// <inheritdoc />
    public partial class AAETravel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b45c61ae-f549-48f7-91b4-51494ee5e914", "0b8d8057-0568-48ec-85de-11bb79c7b948" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6e23274-df00-417b-89d2-6990fc849cb6", "0b8d8057-0568-48ec-85de-11bb79c7b948" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b45c61ae-f549-48f7-91b4-51494ee5e914", "28b06617-0e29-41be-b3b1-f61a1055e8a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6e23274-df00-417b-89d2-6990fc849cb6", "28b06617-0e29-41be-b3b1-f61a1055e8a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b45c61ae-f549-48f7-91b4-51494ee5e914", "697a2c22-7707-4c9b-bb61-5726a9d28600" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6e23274-df00-417b-89d2-6990fc849cb6", "697a2c22-7707-4c9b-bb61-5726a9d28600" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b45c61ae-f549-48f7-91b4-51494ee5e914", "6d3b0cd0-8c08-4a1e-9907-149774925b68" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6e23274-df00-417b-89d2-6990fc849cb6", "6d3b0cd0-8c08-4a1e-9907-149774925b68" });

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "0b8d8057-0568-48ec-85de-11bb79c7b948");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "28b06617-0e29-41be-b3b1-f61a1055e8a5");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "697a2c22-7707-4c9b-bb61-5726a9d28600");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "6d3b0cd0-8c08-4a1e-9907-149774925b68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b45c61ae-f549-48f7-91b4-51494ee5e914");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6e23274-df00-417b-89d2-6990fc849cb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b8d8057-0568-48ec-85de-11bb79c7b948");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28b06617-0e29-41be-b3b1-f61a1055e8a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "697a2c22-7707-4c9b-bb61-5726a9d28600");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d3b0cd0-8c08-4a1e-9907-149774925b68");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0978fa80-b099-4ab2-9412-0b706018f2fb", null, "Visitante", "VISITANTE" },
                    { "c88d90ef-5350-4fda-9f04-ba291eb5f586", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c5de7b6-35a0-4de2-9a96-aac31374a901", 0, "256a1a8c-d563-40ea-9a69-039345206cae", "any.lima@gmail.com", true, true, null, "ANY.LIMA@GMAIL.COM", "ANY", "AQAAAAIAAYagAAAAENGSWZQGC5QoR3wUydA+1xKMs91U04qG1dpyXZRi851sCz+KpZ4S7RQg29+n9CWxng==", null, false, "a01becb8-00bd-4080-b9e1-0844adc9397f", false, "any" },
                    { "29b7a641-5abc-4a7b-8afd-9008fae285a7", 0, "ee214dc6-a431-49d9-9c4d-83afa9d56f51", "ana.silva@aaetravel.com", true, true, null, "ANA.SILVA@AAETRAVEL.COM", "ANA", "AQAAAAIAAYagAAAAEFyMDO0BnP9Lr8MwFiNw1nkEQn+VdeBea5vNGXb+Q/yXfU0JQlrRZoyd3FiueERIxw==", null, false, "26304bbc-1a3c-4303-8cc9-4b17d1edcf94", false, "ana" },
                    { "6735dda8-352e-4913-9b58-6897a3caced3", 0, "7abf36fb-d2c8-45a1-b574-5b30ad1c5105", "eduardo.oliveira@aaetravel.com", true, true, null, "EDUARDO.OLIVEIRA@AAETRAVEL.COM", "EDUARDO", "AQAAAAIAAYagAAAAEEpnP4rWvt7Y/Fmig//kk8jeE8GEqrCgNu6ow1p7HprFW3nhzIeyejJCiQbHVv1ftQ==", null, false, "e0919ea3-cb6b-44cf-b0a9-9d46b01d5793", false, "Eduardo" },
                    { "cd6f8f76-e592-40f0-a4db-4925a5cf793b", 0, "8cc6309c-d624-4481-8fb4-a05ee13effe1", "eduardo.dametto@gmail.com", true, true, null, "EDUARDO.DAMETTO@GMAIL.COM", "DAMETTO", "AQAAAAIAAYagAAAAEA1PJZRbihn3A7gMoxc8T4qsLV7mruba5K7I9hf1wseuMhhtuITXQDkR9S3wjn/zqw==", null, false, "28d183f8-7bbc-48db-ab42-ddd615a714ad", false, "dametto" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0978fa80-b099-4ab2-9412-0b706018f2fb", "1c5de7b6-35a0-4de2-9a96-aac31374a901" },
                    { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "1c5de7b6-35a0-4de2-9a96-aac31374a901" },
                    { "0978fa80-b099-4ab2-9412-0b706018f2fb", "29b7a641-5abc-4a7b-8afd-9008fae285a7" },
                    { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "29b7a641-5abc-4a7b-8afd-9008fae285a7" },
                    { "0978fa80-b099-4ab2-9412-0b706018f2fb", "6735dda8-352e-4913-9b58-6897a3caced3" },
                    { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "6735dda8-352e-4913-9b58-6897a3caced3" },
                    { "0978fa80-b099-4ab2-9412-0b706018f2fb", "cd6f8f76-e592-40f0-a4db-4925a5cf793b" },
                    { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "cd6f8f76-e592-40f0-a4db-4925a5cf793b" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "Cidade", "Descricao", "Foto", "Nome" },
                values: new object[,]
                {
                    { "1c5de7b6-35a0-4de2-9a96-aac31374a901", "Barra Bonita, SP", "Programador junior", "/img/usuarios/2.png", "Eduardo Dametto" },
                    { "29b7a641-5abc-4a7b-8afd-9008fae285a7", "Barra Bonita, SP", "Programador junior", "/img/usuarios/1.png", "Ana Clara Mello da Silva" },
                    { "6735dda8-352e-4913-9b58-6897a3caced3", "Barra Bonita, SP", "Programador junior", "/img/usuarios/avatar.png", "Eduardo Nunes de Oliveira" },
                    { "cd6f8f76-e592-40f0-a4db-4925a5cf793b", "Barra Bonita, SP", "Programador junior", "/img/usuarios/2.png", "Any Gabriele de Lima" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0978fa80-b099-4ab2-9412-0b706018f2fb", "1c5de7b6-35a0-4de2-9a96-aac31374a901" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "1c5de7b6-35a0-4de2-9a96-aac31374a901" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0978fa80-b099-4ab2-9412-0b706018f2fb", "29b7a641-5abc-4a7b-8afd-9008fae285a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "29b7a641-5abc-4a7b-8afd-9008fae285a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0978fa80-b099-4ab2-9412-0b706018f2fb", "6735dda8-352e-4913-9b58-6897a3caced3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "6735dda8-352e-4913-9b58-6897a3caced3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0978fa80-b099-4ab2-9412-0b706018f2fb", "cd6f8f76-e592-40f0-a4db-4925a5cf793b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c88d90ef-5350-4fda-9f04-ba291eb5f586", "cd6f8f76-e592-40f0-a4db-4925a5cf793b" });

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "1c5de7b6-35a0-4de2-9a96-aac31374a901");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "29b7a641-5abc-4a7b-8afd-9008fae285a7");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "6735dda8-352e-4913-9b58-6897a3caced3");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: "cd6f8f76-e592-40f0-a4db-4925a5cf793b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0978fa80-b099-4ab2-9412-0b706018f2fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c88d90ef-5350-4fda-9f04-ba291eb5f586");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5de7b6-35a0-4de2-9a96-aac31374a901");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29b7a641-5abc-4a7b-8afd-9008fae285a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6735dda8-352e-4913-9b58-6897a3caced3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd6f8f76-e592-40f0-a4db-4925a5cf793b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b45c61ae-f549-48f7-91b4-51494ee5e914", null, "Visitante", "VISITANTE" },
                    { "f6e23274-df00-417b-89d2-6990fc849cb6", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b8d8057-0568-48ec-85de-11bb79c7b948", 0, "3d63c411-4d90-49db-b552-378948e32087", "ana.silva@aaetravel.com", true, true, null, "ANA.SILVA@AAETRAVEL.COM", "ANA", "AQAAAAIAAYagAAAAEA/c1y8XzRWPv/gzj97St42/fa2FjWBJSrRDhPvEpEk9xrYxQTlgdeFEzxbZQaRdLA==", null, false, "7c77298d-7c45-4753-b990-d6892a6f731e", false, "ana" },
                    { "28b06617-0e29-41be-b3b1-f61a1055e8a5", 0, "d01ca74a-b729-415d-9fc1-fae93185549e", "eduardo.dametto@gmail.com", true, true, null, "EDUARDO.DAMETTO@GMAIL.COM", "DAMETTO", "AQAAAAIAAYagAAAAEN7VVu2JWiZyPBTneI4y+nKdnQ8u14ecVmvJtr1a4TQgFCYxq+EEcDDroj+iMVf6Rg==", null, false, "710daf5b-167c-4275-bb45-0a9f1559c170", false, "dametto" },
                    { "697a2c22-7707-4c9b-bb61-5726a9d28600", 0, "bf04f7de-2a31-4a28-9333-98bcca281f9f", "any.lima@gmail.com", true, true, null, "ANY.LIMA@GMAIL.COM", "ANY", "AQAAAAIAAYagAAAAEAv9fgQp6ion0xqiD+d+BTVE7NtWig24JJAACNKwSyX27EjBzW/7IoNJTb9M1fVawQ==", null, false, "0abbbb58-d0f9-4b0a-ae29-a4a65f83c543", false, "any" },
                    { "6d3b0cd0-8c08-4a1e-9907-149774925b68", 0, "c27980c8-e228-4933-9007-e8d89ae39bc8", "eduardo.oliveira@aaetravel.com", true, true, null, "EDUARDO.OLIVEIRA@AAETRAVEL.COM", "EDUARDO", "AQAAAAIAAYagAAAAEIBWEWMwki92mrddnIjJpodFRLGhOKvxEeLZ56yTtxJnOFTqwieBhBZIuw360NnEIw==", null, false, "46dc6c31-1cfa-4a77-a791-8b454fed3ee3", false, "Eduardo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b45c61ae-f549-48f7-91b4-51494ee5e914", "0b8d8057-0568-48ec-85de-11bb79c7b948" },
                    { "f6e23274-df00-417b-89d2-6990fc849cb6", "0b8d8057-0568-48ec-85de-11bb79c7b948" },
                    { "b45c61ae-f549-48f7-91b4-51494ee5e914", "28b06617-0e29-41be-b3b1-f61a1055e8a5" },
                    { "f6e23274-df00-417b-89d2-6990fc849cb6", "28b06617-0e29-41be-b3b1-f61a1055e8a5" },
                    { "b45c61ae-f549-48f7-91b4-51494ee5e914", "697a2c22-7707-4c9b-bb61-5726a9d28600" },
                    { "f6e23274-df00-417b-89d2-6990fc849cb6", "697a2c22-7707-4c9b-bb61-5726a9d28600" },
                    { "b45c61ae-f549-48f7-91b4-51494ee5e914", "6d3b0cd0-8c08-4a1e-9907-149774925b68" },
                    { "f6e23274-df00-417b-89d2-6990fc849cb6", "6d3b0cd0-8c08-4a1e-9907-149774925b68" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "Cidade", "Descricao", "Foto", "Nome" },
                values: new object[,]
                {
                    { "0b8d8057-0568-48ec-85de-11bb79c7b948", "Barra Bonita, SP", "Programador junior", "/img/usuarios/1.png", "Ana Clara Mello da Silva" },
                    { "28b06617-0e29-41be-b3b1-f61a1055e8a5", "Barra Bonita, SP", "Programador junior", "/img/usuarios/2.png", "Any Gabriele de Lima" },
                    { "697a2c22-7707-4c9b-bb61-5726a9d28600", "Barra Bonita, SP", "Programador junior", "/img/usuarios/2.png", "Eduardo Dametto" },
                    { "6d3b0cd0-8c08-4a1e-9907-149774925b68", "Barra Bonita, SP", "Programador junior", "/img/usuarios/avatar.png", "Eduardo Nunes de Oliveira" }
                });
        }
    }
}
