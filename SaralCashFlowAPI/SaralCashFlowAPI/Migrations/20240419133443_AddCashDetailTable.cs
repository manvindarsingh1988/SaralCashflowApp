using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaralCashFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCashDetailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashDetails_StatusTypes_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashDetails_StatusId",
                table: "CashDetails",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CashDetails_UserId",
                table: "CashDetails",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashDetails");
        }
    }
}
