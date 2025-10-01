using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gis_vn_after_merge_api.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableAndColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Communes_Provinces_ProvinceId",
                table: "Communes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Communes",
                table: "Communes");

            migrationBuilder.RenameTable(
                name: "Provinces",
                newName: "provinces");

            migrationBuilder.RenameTable(
                name: "Communes",
                newName: "communes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "provinces",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Boundary",
                table: "provinces",
                newName: "boundary");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "provinces",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Population",
                table: "communes",
                newName: "population");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "communes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Boundary",
                table: "communes",
                newName: "boundary");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "communes",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "communes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "communes",
                newName: "province_id");

            migrationBuilder.RenameColumn(
                name: "LegacyId",
                table: "communes",
                newName: "legacy_id");

            migrationBuilder.RenameIndex(
                name: "IX_Communes_ProvinceId",
                table: "communes",
                newName: "IX_communes_province_id");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "communes",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_provinces",
                table: "provinces",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_communes",
                table: "communes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_communes_provinces_province_id",
                table: "communes",
                column: "province_id",
                principalTable: "provinces",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_communes_provinces_province_id",
                table: "communes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_provinces",
                table: "provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_communes",
                table: "communes");

            migrationBuilder.RenameTable(
                name: "provinces",
                newName: "Provinces");

            migrationBuilder.RenameTable(
                name: "communes",
                newName: "Communes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Provinces",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "boundary",
                table: "Provinces",
                newName: "Boundary");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Provinces",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "population",
                table: "Communes",
                newName: "Population");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Communes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "boundary",
                table: "Communes",
                newName: "Boundary");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Communes",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Communes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "province_id",
                table: "Communes",
                newName: "ProvinceId");

            migrationBuilder.RenameColumn(
                name: "legacy_id",
                table: "Communes",
                newName: "LegacyId");

            migrationBuilder.RenameIndex(
                name: "IX_communes_province_id",
                table: "Communes",
                newName: "IX_Communes_ProvinceId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Communes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Communes",
                table: "Communes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Communes_Provinces_ProvinceId",
                table: "Communes",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
