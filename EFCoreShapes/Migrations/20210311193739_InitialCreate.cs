using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreShapes.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfSides = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    radius = table.Column<int>(type: "int", nullable: true),
                    width = table.Column<int>(type: "int", nullable: true),
                    height = table.Column<int>(type: "int", nullable: true),
                    a = table.Column<int>(type: "int", nullable: true),
                    b = table.Column<int>(type: "int", nullable: true),
                    c = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shapes");
        }
    }
}
