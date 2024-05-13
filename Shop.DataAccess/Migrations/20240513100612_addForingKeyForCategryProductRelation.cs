using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopProject.Migrations
{
    /// <inheritdoc />
    public partial class addForingKeyForCategryProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Poducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Poducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Poducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Poducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Poducts_CategoryId",
                table: "Poducts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Poducts_Categories_CategoryId",
                table: "Poducts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poducts_Categories_CategoryId",
                table: "Poducts");

            migrationBuilder.DropIndex(
                name: "IX_Poducts_CategoryId",
                table: "Poducts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Poducts");
        }
    }
}
