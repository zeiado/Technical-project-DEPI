using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_App.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAdminIdFromDietPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietPlans_Admins_AdminId",
                table: "DietPlans");

            migrationBuilder.DropIndex(
                name: "IX_DietPlans_AdminId",
                table: "DietPlans");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "DietPlans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "DietPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DietPlans_AdminId",
                table: "DietPlans",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlans_Admins_AdminId",
                table: "DietPlans",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
