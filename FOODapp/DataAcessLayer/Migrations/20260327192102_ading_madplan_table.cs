using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ading_madplan_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Madplans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Uge = table.Column<int>(type: "INTEGER", nullable: false),
                    år = table.Column<int>(type: "INTEGER", nullable: false),
                    MandagId = table.Column<int>(type: "INTEGER", nullable: false),
                    TisdagId = table.Column<int>(type: "INTEGER", nullable: false),
                    OnsdagId = table.Column<int>(type: "INTEGER", nullable: false),
                    TorsdagId = table.Column<int>(type: "INTEGER", nullable: false),
                    FredagId = table.Column<int>(type: "INTEGER", nullable: false),
                    LørdagId = table.Column<int>(type: "INTEGER", nullable: false),
                    SøndagId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Madplans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Madplans_Recipes_FredagId",
                        column: x => x.FredagId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Madplans_Recipes_LørdagId",
                        column: x => x.LørdagId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Madplans_Recipes_MandagId",
                        column: x => x.MandagId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Madplans_Recipes_OnsdagId",
                        column: x => x.OnsdagId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Madplans_Recipes_SøndagId",
                        column: x => x.SøndagId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Madplans_Recipes_TisdagId",
                        column: x => x.TisdagId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Madplans_Recipes_TorsdagId",
                        column: x => x.TorsdagId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Madplans_FredagId",
                table: "Madplans",
                column: "FredagId");

            migrationBuilder.CreateIndex(
                name: "IX_Madplans_LørdagId",
                table: "Madplans",
                column: "LørdagId");

            migrationBuilder.CreateIndex(
                name: "IX_Madplans_MandagId",
                table: "Madplans",
                column: "MandagId");

            migrationBuilder.CreateIndex(
                name: "IX_Madplans_OnsdagId",
                table: "Madplans",
                column: "OnsdagId");

            migrationBuilder.CreateIndex(
                name: "IX_Madplans_SøndagId",
                table: "Madplans",
                column: "SøndagId");

            migrationBuilder.CreateIndex(
                name: "IX_Madplans_TisdagId",
                table: "Madplans",
                column: "TisdagId");

            migrationBuilder.CreateIndex(
                name: "IX_Madplans_TorsdagId",
                table: "Madplans",
                column: "TorsdagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Madplans");
        }
    }
}
