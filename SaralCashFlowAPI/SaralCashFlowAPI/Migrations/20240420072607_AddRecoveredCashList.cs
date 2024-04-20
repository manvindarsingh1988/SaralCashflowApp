using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaralCashFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRecoveredCashList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubCashDetailsId",
                table: "SubCashDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCashDetails_SubCashDetailsId",
                table: "SubCashDetails",
                column: "SubCashDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCashDetails_SubCashDetails_SubCashDetailsId",
                table: "SubCashDetails",
                column: "SubCashDetailsId",
                principalTable: "SubCashDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCashDetails_SubCashDetails_SubCashDetailsId",
                table: "SubCashDetails");

            migrationBuilder.DropIndex(
                name: "IX_SubCashDetails_SubCashDetailsId",
                table: "SubCashDetails");

            migrationBuilder.DropColumn(
                name: "SubCashDetailsId",
                table: "SubCashDetails");
        }
    }
}
