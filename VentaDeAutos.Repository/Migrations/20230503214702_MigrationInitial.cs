using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VentaDeAutos.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoCedans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    color = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Transmición = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoDeFrenos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Capacidad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Stock = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoCedans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoCedans");
        }
    }
}
