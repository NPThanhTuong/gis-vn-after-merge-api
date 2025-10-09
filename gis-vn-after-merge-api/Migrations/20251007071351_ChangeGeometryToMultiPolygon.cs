using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace gis_vn_after_merge_api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGeometryToMultiPolygon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 1,
                column: "boundary",
                value: (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((105.81 21.03, 105.83 21.03, 105.83 21.05, 105.81 21.05, 105.81 21.03)))"));

            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 2,
                column: "boundary",
                value: (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((106.7 10.77, 106.72 10.77, 106.72 10.79, 106.7 10.79, 106.7 10.77)))"));

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 1,
                column: "boundary",
                value: (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((105.8 21, 105.9 21, 105.9 21.1, 105.8 21.1, 105.8 21)))"));

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 2,
                column: "boundary",
                value: (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((106.6 10.7, 106.8 10.7, 106.8 10.9, 106.6 10.9, 106.6 10.7)))"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 1,
                column: "boundary",
                value: (NetTopologySuite.Geometries.GeometryCollection)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;GEOMETRYCOLLECTION (POLYGON ((105.81 21.03, 105.83 21.03, 105.83 21.05, 105.81 21.05, 105.81 21.03)))"));

            migrationBuilder.UpdateData(
                table: "communes",
                keyColumn: "id",
                keyValue: 2,
                column: "boundary",
                value: (NetTopologySuite.Geometries.GeometryCollection)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;GEOMETRYCOLLECTION (POLYGON ((106.7 10.77, 106.72 10.77, 106.72 10.79, 106.7 10.79, 106.7 10.77)))"));

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 1,
                column: "boundary",
                value: (NetTopologySuite.Geometries.GeometryCollection)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;GEOMETRYCOLLECTION (POLYGON ((105.8 21, 105.9 21, 105.9 21.1, 105.8 21.1, 105.8 21)))"));

            migrationBuilder.UpdateData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 2,
                column: "boundary",
                value: (NetTopologySuite.Geometries.GeometryCollection)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;GEOMETRYCOLLECTION (POLYGON ((106.6 10.7, 106.8 10.7, 106.8 10.9, 106.6 10.9, 106.6 10.7)))"));
        }
    }
}
