using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaralCashFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMessageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CashDetailId = table.Column<int>(type: "int", nullable: true),
                    SubCashDetailsId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_CashDetails_CashDetailId",
                        column: x => x.CashDetailId,
                        principalTable: "CashDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_SubCashDetails_SubCashDetailsId",
                        column: x => x.SubCashDetailsId,
                        principalTable: "SubCashDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CashDetailId",
                table: "Messages",
                column: "CashDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SubCashDetailsId",
                table: "Messages",
                column: "SubCashDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
