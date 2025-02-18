﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseManagement.Migrations.Warehouse
{
    public partial class WarehouseDatabaseInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wCathegory",
                columns: table => new
                {
                    wCathegoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wCathegory", x => x.wCathegoryId);
                });

            migrationBuilder.CreateTable(
                name: "wItems",
                columns: table => new
                {
                    wItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    cathegorywCathegoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wItems", x => x.wItemId);
                    table.ForeignKey(
                        name: "FK_wItems_wCathegory_cathegorywCathegoryId",
                        column: x => x.cathegorywCathegoryId,
                        principalTable: "wCathegory",
                        principalColumn: "wCathegoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wItems_cathegorywCathegoryId",
                table: "wItems",
                column: "cathegorywCathegoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wItems");

            migrationBuilder.DropTable(
                name: "wCathegory");
        }
    }
}
