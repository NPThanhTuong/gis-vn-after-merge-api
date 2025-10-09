using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gis_vn_after_merge_api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeedSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "communes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "communes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "provinces",
                columns: new[] { "id", "boundary", "legacy_id", "name" },
                values: new object[,]
                {
                    { 1, (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((105.8 21, 105.9 21, 105.9 21.1, 105.8 21.1, 105.8 21)))"), 0, "Hà Nội" },
                    { 2, (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((106.6 10.7, 106.8 10.7, 106.8 10.9, 106.6 10.9, 106.6 10.7)))"), 0, "Hồ Chí Minh" }
                });

            migrationBuilder.InsertData(
                table: "communes",
                columns: new[] { "id", "area", "boundary", "legacy_id", "name", "population", "province_id" },
                values: new object[,]
                {
                    { 1, 9.1999999999999993, (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((105.81 21.03, 105.83 21.03, 105.83 21.05, 105.81 21.05, 105.81 21.03)))"), 1001, "Ba Đình", 230000, 1 },
                    { 2, 7.7000000000000002, (NetTopologySuite.Geometries.MultiPolygon)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;MULTIPOLYGON (((106.7 10.77, 106.72 10.77, 106.72 10.79, 106.7 10.79, 106.7 10.77)))"), 2001, "Quận 1", 142000, 2 }
                });
        }
    }
}
