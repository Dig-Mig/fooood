using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Lazy_loading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");
        }
    }
}
