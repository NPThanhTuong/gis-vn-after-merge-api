using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace gis_vn_after_merge_api.Models;

[Table("communes")]
public class Commune
{
	[Column("id")] public int Id { get; set; }

	[Column("legacy_id")] public int LegacyId { get; set; }

	[Column("name")] [MaxLength(50)] public required string Name { get; set; }

	[Column("area")] public required double Area { get; set; }

	[Column("population")] public required int Population { get; set; }

	[Column("boundary")] public required Geometry Boundary { get; set; }

	[Column("province_id")] public int ProvinceId { get; set; }

	public Province Province { get; set; } = null!;
}