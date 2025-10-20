using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gis_vn_after_merge_api.Migrations
{
    /// <inheritdoc />
    public partial class AddTwoFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "administrative_center ",
                table: "provinces",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "merge_from",
                table: "provinces",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "administrative_center ",
                table: "communes",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "merge_from",
                table: "communes",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "administrative_center ",
                table: "provinces");

            migrationBuilder.DropColumn(
                name: "merge_from",
                table: "provinces");

            migrationBuilder.DropColumn(
                name: "administrative_center ",
                table: "communes");

            migrationBuilder.DropColumn(
                name: "merge_from",
                table: "communes");
        }
    }
}
