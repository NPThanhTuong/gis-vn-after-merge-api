using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gis_vn_after_merge_api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "administrative_center ",
                table: "provinces",
                newName: "administrative_center");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "administrative_center",
                table: "provinces",
                newName: "administrative_center ");
        }
    }
}
