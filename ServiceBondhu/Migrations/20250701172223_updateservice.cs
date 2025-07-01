using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceBondhu.Migrations
{
    /// <inheritdoc />
    public partial class updateservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryCategoryId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceCategoryCategoryId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceCategoryCategoryId",
                table: "Services");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceCategories_CategoryId",
                table: "Services",
                column: "CategoryId",
                principalTable: "ServiceCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceCategories_CategoryId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_CategoryId",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "ServiceCategoryCategoryId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceCategoryCategoryId",
                table: "Services",
                column: "ServiceCategoryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryCategoryId",
                table: "Services",
                column: "ServiceCategoryCategoryId",
                principalTable: "ServiceCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
