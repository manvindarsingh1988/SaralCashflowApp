﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaralCashFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSubCashDetailsInCashDetailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CashDetailId",
                table: "SubCashDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCashDetails_CashDetailId",
                table: "SubCashDetails",
                column: "CashDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCashDetails_CashDetails_CashDetailId",
                table: "SubCashDetails",
                column: "CashDetailId",
                principalTable: "CashDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCashDetails_CashDetails_CashDetailId",
                table: "SubCashDetails");

            migrationBuilder.DropIndex(
                name: "IX_SubCashDetails_CashDetailId",
                table: "SubCashDetails");

            migrationBuilder.DropColumn(
                name: "CashDetailId",
                table: "SubCashDetails");
        }
    }
}
