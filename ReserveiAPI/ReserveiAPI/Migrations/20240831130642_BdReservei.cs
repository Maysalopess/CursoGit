﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ReserveiAPI.Migrations
{
    /// <inheritdoc />
    public partial class BdReservei : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    iduser = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imageprofile = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    nameuser = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    emailuser = table.Column<string>(type: "text", nullable: false),
                    passworduser = table.Column<string>(type: "text", nullable: false),
                    phoneuser = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.iduser);
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "iduser", "emailuser", "imageprofile", "nameuser", "passworduser", "phoneuser" },
                values: new object[] { 1, "master@dev.com", "", "Master", "15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
