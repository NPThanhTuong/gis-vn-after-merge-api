using gis_vn_after_merge_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace gis_vn_after_merge_api.Configurations;

public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
{
	public void Configure(EntityTypeBuilder<Province> builder)
	{
		var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(4326);

		builder.HasData(
			new Province
			{
				Id = 1,
				Name = "Hà Nội",
				Boundary = geometryFactory.CreateMultiPolygon([
					geometryFactory.CreatePolygon([
						new Coordinate(105.8, 21.0),
						new Coordinate(105.9, 21.0),
						new Coordinate(105.9, 21.1),
						new Coordinate(105.8, 21.1),
						new Coordinate(105.8, 21.0)
					])
				])
			},
			new Province
			{
				Id = 2,
				Name = "Hồ Chí Minh",
				Boundary = geometryFactory.CreateMultiPolygon([
					geometryFactory.CreatePolygon([
						new Coordinate(106.6, 10.7),
						new Coordinate(106.8, 10.7),
						new Coordinate(106.8, 10.9),
						new Coordinate(106.6, 10.9),
						new Coordinate(106.6, 10.7)
					])
				])
			}
		);
	}
}