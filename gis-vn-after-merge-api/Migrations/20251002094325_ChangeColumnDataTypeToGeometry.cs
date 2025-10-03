using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace gis_vn_after_merge_api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnDataTypeToGeometry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "legacy_id",
                table: "provinces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 1,
                column: "boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((105.81 21.03, 105.83 21.03, 105.83 21.05, 105.81 21.05, 105.81 21.03))"));

            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 2,
                column: "boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((106.7 10.77, 106.72 10.77, 106.72 10.79, 106.7 10.79, 106.7 10.77))"));

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "boundary", "legacy_id" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((105.8 21, 105.9 21, 105.9 21.1, 105.8 21.1, 105.8 21))"), 0 });

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "boundary", "legacy_id" },
                values: new object[] { (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((106.6 10.7, 106.8 10.7, 106.8 10.9, 106.6 10.9, 106.6 10.7))"), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "legacy_id",
                table: "provinces");

            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 1,
                column: "boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((105.81 21.03, 105.83 21.03, 105.83 21.05, 105.81 21.05, 105.81 21.03))"));

            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 2,
                column: "boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((106.7 10.77, 106.72 10.77, 106.72 10.79, 106.7 10.79, 106.7 10.77))"));

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 1,
                column: "boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((105.8 21, 105.9 21, 105.9 21.1, 105.8 21.1, 105.8 21))"));

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 2,
                column: "boundary",
                value: (NetTopologySuite.Geometries.Polygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POLYGON ((106.6 10.7, 106.8 10.7, 106.8 10.9, 106.6 10.9, 106.6 10.7))"));
        }
    }
}
