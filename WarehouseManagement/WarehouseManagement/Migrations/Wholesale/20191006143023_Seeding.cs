using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseManagement.Migrations.Wholesale
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Cathegory_CathegoryId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cathegory",
                table: "Cathegory");

            migrationBuilder.RenameTable(
                name: "Cathegory",
                newName: "Cathegories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cathegories",
                table: "Cathegories",
                column: "CathegoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Cathegories_CathegoryId",
                table: "Items",
                column: "CathegoryId",
                principalTable: "Cathegories",
                principalColumn: "CathegoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Cathegories_CathegoryId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cathegories",
                table: "Cathegories");

            migrationBuilder.RenameTable(
                name: "Cathegories",
                newName: "Cathegory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cathegory",
                table: "Cathegory",
                column: "CathegoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Cathegory_CathegoryId",
                table: "Items",
                column: "CathegoryId",
                principalTable: "Cathegory",
                principalColumn: "CathegoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
