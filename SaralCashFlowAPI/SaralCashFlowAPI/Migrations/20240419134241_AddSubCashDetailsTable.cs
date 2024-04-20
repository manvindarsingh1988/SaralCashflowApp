using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaralCashFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSubCashDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCashDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CollectorId = table.Column<int>(type: "int", nullable: false),
                    AmountTypeId = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCashDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCashDetails_AmountTypes_AmountTypeId",
                        column: x => x.AmountTypeId,
                        principalTable: "AmountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCashDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCashDetails_StatusTypes_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCashDetails_Users_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCashDetails_AmountTypeId",
                table: "SubCashDetails",
                column: "AmountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCashDetails_CollectorId",
                table: "SubCashDetails",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCashDetails_CustomerId",
                table: "SubCashDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCashDetails_StatusId",
                table: "SubCashDetails",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCashDetails");
        }
    }
}
