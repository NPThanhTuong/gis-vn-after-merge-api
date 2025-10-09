using gis_vn_after_merge_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace gis_vn_after_merge_api.Configurations;

public class CommuneConfiguration : IEntityTypeConfiguration<Commune>
{
	public void Configure(EntityTypeBuilder<Commune> builder)
	{
		var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(4326);

		builder.HasData(
			new Commune
			{
				Id = 1,
				LegacyId = 1001,
				Name = "Ba Đình",
				Area = 9.2,
				Population = 230000,
				ProvinceId = 1,
				Boundary = geometryFactory.CreateMultiPolygon([
					geometryFactory.CreatePolygon([
						new Coordinate(105.81, 21.03),
						new Coordinate(105.83, 21.03),
						new Coordinate(105.83, 21.05),
						new Coordinate(105.81, 21.05),
						new Coordinate(105.81, 21.03)
					])
				])
			},
			new Commune
			{
				Id = 2,
				LegacyId = 2001,
				Name = "Quận 1",
				Area = 7.7,
				Population = 142000,
				ProvinceId = 2,
				Boundary = geometryFactory.CreateMultiPolygon([
					geometryFactory.CreatePolygon([
						new Coordinate(106.7, 10.77),
						new Coordinate(106.72, 10.77),
						new Coordinate(106.72, 10.79),
						new Coordinate(106.7, 10.79),
						new Coordinate(106.7, 10.77)
					])
				])
			}
		);

	}
}