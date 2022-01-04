using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Server.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expression = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Memories",
                columns: new[] { "Id", "Expression", "Result" },
                values: new object[] { 1, "2+2", 4.0 });

            migrationBuilder.InsertData(
                table: "Memories",
                columns: new[] { "Id", "Expression", "Result" },
                values: new object[] { 2, "6*6", 36.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memories");
        }
    }
}
