using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gis_vn_after_merge_api.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Communes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Communes_ProvinceId",
                table: "Communes",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Communes_Provinces_ProvinceId",
                table: "Communes",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Communes_Provinces_ProvinceId",
                table: "Communes");

            migrationBuilder.DropIndex(
                name: "IX_Communes_ProvinceId",
                table: "Communes");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Communes");
        }
    }
}
