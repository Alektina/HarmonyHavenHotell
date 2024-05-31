using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarmonyHaven.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDataProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ProductDescription",
                value: "The Inner fill: 100% new white duck feathersThe outer fill: natural hybrid blend of new white duck down 90% and sustainable fibre balls, Pillow case: 100% cotton.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ProductDescription",
                value: "The Inner fill: 100% new white duck feathers (51 x 66 cm : 640g / 51 x 71 cm : 690g / 51 x 91 cm : 865g), The outer fill: natural hybrid blend of new white duck down 90% and sustainable fibre balls (51 x 66 cm : 200g / 51 x 71 cm : 220g / 51 x 91 cm : 280g), Pillow case: 100% cotton.");
        }
    }
}
