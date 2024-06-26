﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRelationships.Migrations
{
    /// <inheritdoc />
    public partial class addhouse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HouseId",
                table: "Characters",
                column: "HouseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Houses_HouseId",
                table: "Characters",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Houses_HouseId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Characters_HouseId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Characters");
        }
    }
}
