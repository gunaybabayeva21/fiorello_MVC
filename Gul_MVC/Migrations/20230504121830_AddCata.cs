using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gul_MVC.Migrations
{
    public partial class AddCata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatagoryProdact_prodacts_ProdactsId",
                table: "CatagoryProdact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tags",
                table: "tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prodacts",
                table: "prodacts");

            migrationBuilder.RenameTable(
                name: "tags",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "prodacts",
                newName: "Prodacts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "catagory",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prodacts",
                table: "Prodacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatagoryProdact_Prodacts_ProdactsId",
                table: "CatagoryProdact",
                column: "ProdactsId",
                principalTable: "Prodacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatagoryProdact_Prodacts_ProdactsId",
                table: "CatagoryProdact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prodacts",
                table: "Prodacts");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "tags");

            migrationBuilder.RenameTable(
                name: "Prodacts",
                newName: "prodacts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "catagory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tags",
                table: "tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prodacts",
                table: "prodacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatagoryProdact_prodacts_ProdactsId",
                table: "CatagoryProdact",
                column: "ProdactsId",
                principalTable: "prodacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
