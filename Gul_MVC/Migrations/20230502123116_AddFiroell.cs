using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gul_MVC.Migrations
{
    public partial class AddFiroell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catagory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catagory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "prodacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prodacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatagoryProdact",
                columns: table => new
                {
                    CatagoriesId = table.Column<int>(type: "int", nullable: false),
                    ProdactsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryProdact", x => new { x.CatagoriesId, x.ProdactsId });
                    table.ForeignKey(
                        name: "FK_CatagoryProdact_catagory_CatagoriesId",
                        column: x => x.CatagoriesId,
                        principalTable: "catagory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatagoryProdact_prodacts_ProdactsId",
                        column: x => x.ProdactsId,
                        principalTable: "prodacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatagoryProdact_ProdactsId",
                table: "CatagoryProdact",
                column: "ProdactsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatagoryProdact");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "catagory");

            migrationBuilder.DropTable(
                name: "prodacts");
        }
    }
}
