using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_App.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddNewAttributeForDietPlans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "DietPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlanTitle",
                table: "DietPlans",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "DietPlans");

            migrationBuilder.DropColumn(
                name: "PlanTitle",
                table: "DietPlans");
        }
    }
}
