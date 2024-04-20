using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaralCashFlowAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Roles", "Name", "Initiator");
            migrationBuilder.InsertData("Roles", "Name", "Collector");
            migrationBuilder.InsertData("Roles", "Name", "Accountent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Roles", "Name", "Initiator");
            migrationBuilder.DeleteData("Roles", "Name", "Collector");
            migrationBuilder.DeleteData("Roles", "Name", "Accountent");
        }
    }
}
