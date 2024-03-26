using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCA_MVC_TP9_PB.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "professors",
                columns: table => new
                {
                    matricula = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Titulacao = table.Column<string>(type: "TEXT", nullable: false),
                    FormaContratada = table.Column<string>(type: "TEXT", nullable: false),
                    Curriculo = table.Column<string>(type: "TEXT", nullable: false),
                    Horario = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professors", x => x.matricula);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "professors");
        }
    }
}
